namespace Mbk.Discord.UI;

public partial class EventsPage 
{
	[ConCmd.Server]
	public static void SaveBroadCast(string identifier, bool value)
	{
		Log.Info( "SaveBroadCast" );
		DiscordSystem.GetGameEvent( identifier ).Broadcast = value;
		DiscordSystem.SaveEvents();
	}

	[ConCmd.Server]
	public static void SaveDisplayEmbed(string identifier, bool value )
	{
		Log.Info("SaveDisplayEmbed");

		DiscordSystem.GetGameEvent( identifier ).DisplayEmbed = value;
		DiscordSystem.SaveEvents();
	}

	[ConCmd.Server]
	public static void SaveEmbedColor(string identifier, string value)
	{
		DiscordSystem.GetGameEvent( identifier ).HexColorEmbed = value;
		DiscordSystem.SaveEvents();
	}

	[ConCmd.Server]
	public static void SaveUseAsBot(string identifier, bool value )
	{
		DiscordSystem.GetGameEvent( identifier ).UseAsBot = value;
		DiscordSystem.SaveEvents();
	}

	[ConCmd.Server]
	public static void SaveChannelID(string identifier, long value)
	{
		DiscordSystem.GetGameEvent( identifier ).ChannelID = value;
		DiscordSystem.SaveEvents();
	}

	[ConCmd.Server]
	public static void SaveWebhook(string identifier, string value)
	{
		DiscordSystem.GetGameEvent( identifier ).Webhook = value;
		DiscordSystem.SaveEvents();
	}
}
