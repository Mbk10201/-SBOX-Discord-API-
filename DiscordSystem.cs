using Mbk.Discord.Attributes;
using Mbk.Discord.Models;
using Mbk.Discord.UI;
using System.ComponentModel.DataAnnotations;

namespace Mbk.Discord;

[Library(Title = "Discord")]
[Display( Name = "Discord" ), Category( "Discord" ), Icon( "webhook" )]
public partial class DiscordSystem : Entity
{
	public static DiscordSystem Instance { get; private set; }
	private static BaseFileSystem path => FileSystem.Data;
	
	[Net] public IList<GameEventSettings> GameEventList { get; set; }

	public DiscordSystem()
	{
		Instance = this;

		if ( Game.IsServer )
		{
			GameEventList = new List<GameEventSettings>();
			_ = new Client();

			if ( !path.FileExists( "discord_events.json" ) )
				SaveEvents();
			else
				LoadEvents();
		}
	}

	public override void ClientSpawn()
	{
		base.Spawn();
	}

	public override void Spawn()
	{
		Transmit = TransmitType.Always;
		base.Spawn();
	}

	[GameEvent.Entity.PostSpawn]
	public static void Initialize()
	{
		Game.AssertServer();
		_ = new DiscordSystem();
	}

	[GameEvent.Client.Frame]
	public static void Frame()
	{
		if (Game.RootPanel.Children.OfType<DiscordUI>().Count() == 0)
			Game.RootPanel.AddChild<DiscordUI>();
	}

	public static IList<GameEventSettings> GetGameEventList() => Instance.GameEventList;
	public static GameEventSettings GetGameEvent( string identifier ) => Instance.GameEventList.Single( x => x.Identifier == identifier );

	public void LoadEvents()
	{
		GameEventList = path.ReadJson<IList<GameEventSettings>>( "discord_events.json" );

		foreach ( var method in TypeLibrary.GetMethodsWithAttribute<DiscordGameEvent>())
		{
			if(!GameEventList.Any( x => x.Identifier == method.Attribute.Identifier ))
			{
				GameEventList?.Add( new()
				{
					Identifier = method.Attribute.Identifier,
					Name = method.Attribute.Name,
					Description = method.Attribute.Description
				} );
				SaveEvents();
			}
		}
	}

	public static void SaveEvents( )
	{
		path.WriteJson( "discord_events.json", GetGameEventList() );
		Instance.LoadEvents();
	}
}
