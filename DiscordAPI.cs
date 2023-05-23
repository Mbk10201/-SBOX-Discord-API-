using DiscordAPI.Models;
using DiscordAPI.UI;
using System.Collections.Generic;
using System.Linq;

namespace DiscordAPI;

public static partial class DiscordAPI
{
	public static Bot Bot { get; private set; }
	public static Webhook Webhook { get; private set; }
	public static Settings Settings { get; set; }
	public static List<EventSettings> EventList { get; private set; } = new();
	//public static List<> Logs { get; private set; }

	[GameEvent.Entity.PostSpawn]
	public static void Initialise()
	{
		Log.Info( "Discord A.P.I [V1.0]" );

		Settings = new Settings();
		Bot = new( /*"MTExMDI1Nzc2ODI1MTgwMTc3MQ.GsD1Q5.HpskngoxHDVUb0BcBEwkJ0i8T4oP0IqDDl5KPs"*/ );
		Webhook = new();

		if ( !FileSystem.OrganizationData.FileExists( "discord_events.json" ) )
			SaveEvents();
		else
			LoadEvent();
	}

	[GameEvent.Client.Frame]
	public static void Frame()
	{
		if (Game.RootPanel.Children.OfType<DiscordUI>().Count() == 0)
			Game.RootPanel.AddChild<DiscordUI>();
	}

	public static void RegisterEvent( EventSettings eventsettings )
	{
		EventList.Add( eventsettings );
		SaveEvents();
	}

	public static void LoadEvent()
	{
		var data = FileSystem.OrganizationData.ReadJson<List<EventSettings>>( "discord_events.json" );
	}

	public static void SaveEvents( )
	{
		FileSystem.OrganizationData.WriteJson( "discord_events.json", EventList );
	}
}
