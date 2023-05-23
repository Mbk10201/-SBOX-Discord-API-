using DiscordAPI.Models;
using DiscordAPI.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscordAPI;

public static partial class Discord
{
	public static List<EventSettings> EventList { get; private set; }
	//public static List<> Logs { get; private set; }

	[GameEvent.Entity.PostSpawn]
	public static void Initialise()
	{
		Log.Info( "Discord A.P.I [V1.0]" );

		EventList = new();

		Bot.Load();

		if ( !FileSystem.OrganizationData.FileExists( "discord_events.json" ) )
			SaveEvents();
		else
			LoadEvents();
	}

	[GameEvent.Client.Frame]
	public static void Frame()
	{
		if (Game.RootPanel.Children.OfType<DiscordUI>().Count() == 0)
			Game.RootPanel.AddChild<DiscordUI>();
	}

	public static void RegisterEvent( EventSettings eventsettings )
	{
		EventList?.Add( eventsettings );
		SaveEvents();
	}

	public static void LoadEvents()
	{
		EventList = FileSystem.OrganizationData.ReadJson<List<EventSettings>>( "discord_events.json" );

		foreach ( var method in TypeLibrary.GetMethodsWithAttribute<RegisterDiscordEvent>())
		{
			if ( !EventList.Exists( x => x.Identifier == method.Attribute.Identifier ) )
			{
				RegisterEvent( new()
				{
					Identifier = method.Attribute.Identifier,
					Name = method.Attribute.Name,
					Description = method.Attribute.Description,
					Category = method.Attribute.Category
				} );
			}
			else
				continue;
		}
	}

	public static void SaveEvents( )
	{
		FileSystem.OrganizationData.WriteJson( "discord_events.json", EventList );
		LoadEvents();
	}
}
