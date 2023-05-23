using DiscordAPI.Models;
using DiscordAPI.UI;
using Sandbox;
using System.Linq;

namespace DiscordAPI;

public static partial class DiscordAPI
{
	public static Bot Bot { get; private set; }
	public static Webhook Webhook { get; private set; }
	public static Settings Settings { get; set; }

	[GameEvent.Entity.PostSpawn]
	public static void Initialise()
	{
		Log.Info( "Discord A.P.I [V1.0]" );

		Settings = new Settings();
		Bot = new( /*"MTExMDI1Nzc2ODI1MTgwMTc3MQ.GsD1Q5.HpskngoxHDVUb0BcBEwkJ0i8T4oP0IqDDl5KPs"*/ );
		Webhook = new();
	}

	[GameEvent.Client.Frame]
	public static void Frame()
	{
		if (Game.RootPanel.Children.OfType<DiscordUI>().Count() == 0)
			Game.RootPanel.AddChild<DiscordUI>();
	}
}
