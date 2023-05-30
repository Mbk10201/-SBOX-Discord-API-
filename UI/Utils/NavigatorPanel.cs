namespace Discord.UI.Utils;

/// <summary>
/// A panel that acts like a website. A single page is always visible
/// but it will cache other views that you visit, and allow forward/backward navigation.
/// </summary>
[Library( "navigator" )]
public class NavigatorPanel : Panel
{
	public Panel CurrentPanel => Current?.Panel;
	public string CurrentUrl => Current?.Url;
	public string CurrentQuery;
	public string DefaultUrl { get; set; }

	public Panel NavigatorCanvas { get; set; }

	protected class HistoryItem
	{
		public Panel Panel;
		public string Url;
	}

	/// <summary>
	/// Called after initialization
	/// </summary>
	protected override void OnParametersSet()
	{
		if ( DefaultUrl != null && CurrentUrl == null )
		{
			Navigate( DefaultUrl );
		}
	}

	internal void RemoveUrls( Func<string, bool> p )
	{
		var removes = Cache.Where( x => p( x.Url ) ).ToArray();

		foreach ( var remove in removes )
		{
			remove.Panel.Delete();
			Cache.Remove( remove );
		}
	}

	public override void OnTemplateSlot( INode element, string slotName, Panel panel )
	{
		if ( slotName == "navigator-canvas" )
		{
			NavigatorCanvas = panel;

			foreach ( var p in Cache )
			{
				p.Panel.Parent = NavigatorCanvas;
			}

			return;
		}

		base.OnTemplateSlot( element, slotName, panel );
	}

	protected List<HistoryItem> Cache = new();

	HistoryItem Current;
	Stack<HistoryItem> Back = new();
	Stack<HistoryItem> Forward = new();

	public void Navigate( string url )
	{
		string query = "";
		string originalUrl = url;
		bool foundPartial = false;

		if ( url?.Contains( '?' ) ?? false )
		{
			var qi = url.IndexOf( '?' );
			query = url.Substring( qi + 1 );
			url = url.Substring( 0, qi );

			//Log.Info( $"Query: {query}" );
			//Log.Info( $"Url: {url}" );
		}

		//
		// Find a NavigatorPanel that we're a child of
		//
		var parent = Ancestors.OfType<NavigatorPanel>().FirstOrDefault();

		//
		// Make url absolute by adding it to parent url
		//
		if ( url?.StartsWith( "~/" ) ?? false && parent != null )
		{
			url = $"{parent.CurrentUrl}/{url[2..]}";
		}

		if ( url == CurrentUrl )
		{
			ApplyQuery( query );
			return;
		}

		if ( NavigatorCanvas == null )
		{
			NavigatorCanvas = this;
		}

		var previousUrl = CurrentUrl;

		var attr = RouteAttribute.FindValidTarget( url, parent?.CurrentUrl );
		if ( !attr.HasValue )
		{
			if ( DefaultUrl != null )
			{
				Navigate( DefaultUrl );
				return;
			}

			NotFound( url );
			return;
		}

		//Log.Info( $"NavPanel - [{url}] - [{attr.Value.Attribute.Url}]" );

		//
		// If the URl contains a *, it's a partial url. This expects the matching
		// page to have a NavigatorPanel in it - which will forfil the rest of the url
		//
		if ( attr.Value.Attribute.Url.Contains( '*' ) )
		{
			foundPartial = true;

			// the full url might be something like
			// game/blahblah/front
			// but the url of this navigator might be
			// game/{ident}/*
			// so change the url to 
			// game/blahblah
			// stripping off extra parts

			var partCount = attr.Value.Attribute.Parts.Count();
			var currentParts = url.Split( "/" ).Take( partCount );
			url = string.Join( "/", currentParts );
		}


		Forward.Clear();

		if ( Current != null )
		{
			Back.Push( Current );
			Current.Panel.AddClass( "hidden" );
			Current = null;
		}

		var cached = Cache.FirstOrDefault( x => x.Url == url );
		if ( cached != null )
		{
			cached.Panel.RemoveClass( "hidden" );
			Current = cached;
			Current.Panel.Parent = NavigatorCanvas;
		}
		else
		{
			var panel = attr.Value.Type.Create<Panel>();
			if ( panel  == null )
			{
				Log.Warning( $"Found a Route attribute - but we couldn't create the panel ({attr.Value.Type})" );
				return;
			}
			panel.AddClass( "navigator-body" );

			Current = new HistoryItem { Panel = panel, Url = url };
			Current.Panel.Parent = NavigatorCanvas;

			foreach ( var (key, value) in attr.Value.Attribute.ExtractProperties( url ) )
			{
				panel.SetProperty( key, value );
			}

			Cache.Add( Current );
			StateHasChanged();
		}

		if ( Current == null ) return;

		//
		// If we're a partial url, find the child NavigatorPanel and
		// send it the rest of the url
		//
		if ( foundPartial )
		{
			var childNavigator = Current.Panel as NavigatorPanel;

			if ( childNavigator  == null )
				childNavigator = Current.Panel.Descendants.OfType<NavigatorPanel>().FirstOrDefault();

			//Log.Info( $"Telling childNavigator [{Current.Panel}] => [{childNavigator}] to go to {originalUrl}" );
			
			if ( childNavigator != null )
			{
				childNavigator.Navigate( originalUrl );
			}
		}

		Current.Panel.SetProperty( "referrer", previousUrl );
		ApplyQuery( query );
	}

	void ApplyQuery( string query )
	{
		if ( string.IsNullOrWhiteSpace( query ) )
			return;

		var parts = System.Web.HttpUtility.ParseQueryString( query );
		foreach ( var key in parts.AllKeys )
		{
			Current.Panel.SetProperty( key, parts.Get( key ) );
		}
	}

	protected virtual void NotFound( string url )
	{
		if ( url == null ) return;
		Log.Warning( $"Url Not Found: {url}" );
	}

	internal bool CurrentUrlMatches( string url )
	{
		if ( url != null && url.StartsWith( "~" ) )
			return CurrentUrl?.EndsWith( url[1..] ) ?? false;

		if ( CurrentUrl == null )
			return url == null;

		return CurrentUrl.WildcardMatch( url );
	}

	public override void SetProperty( string name, string value )
	{
		base.SetProperty( name, value );

		if ( name == "default" )
			DefaultUrl = value;
	}

	/// <summary>
	/// Navigate to a URL
	/// </summary>
	[PanelEvent]
	public bool NavigateEvent( string url )
	{
		Navigate( url );
		return false;
	}


	/// <summary>
	/// 
	/// </summary>
	[PanelEvent( "navigate_return" )]
	public bool NavigateReturnEvent()
	{
		if ( !Back.TryPop( out var result ) )
			return true;

		Switch( result );
		return false;
	}

	protected override void OnBack( PanelEvent e )
	{
		if ( GoBack() )
		{
			e.StopPropagation();
		}
	}

	protected override void OnForward( PanelEvent e )
	{
		if ( GoForward() )
		{
			e.StopPropagation();
		}
	}

	public virtual bool GoBackUntilNot( string wildcard )
	{
		if ( GoBack() )
		{
			if ( !Current.Url.WildcardMatch( wildcard ) )
				return true;

			return GoBackUntilNot( wildcard );
		}

		return false;
	}

	public virtual bool GoBack()
	{
		if ( !Back.TryPop( out var result ) )
		{
			// TODO - only play this sound if we didn't pass to a parent
			PlaySound( "ui.navigate.deny" );
			return false;
		}

		if ( !Cache.Contains( result ) || result.Panel == null )
		{
			return GoBack();
		}

		PlaySound( "ui.navigate.back" );

		if ( Current != null )
			Forward.Push( Current );

		Switch( result );
		return true;
	}

	public virtual bool GoForward()
	{
		if ( !Forward.TryPop( out var result ) )
		{
			PlaySound( "ui.navigate.deny" );
			return false;
		}

		if ( !Cache.Contains( result ) || result.Panel == null )
		{
			return GoForward();
		}

		PlaySound( "ui.navigate.forward" );

		if ( Current != null )
			Back.Push( Current );

		Switch( result );
		return true;
	}

	void Switch( HistoryItem item )
	{
		if ( Current == item ) return;

		Current?.Panel.AddClass( "hidden" );
		Current = null;

		Current = item;
		Current?.Panel.RemoveClass( "hidden" );
	}
}
