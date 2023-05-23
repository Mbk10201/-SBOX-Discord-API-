using DiscordAPI.Models;
using Sandbox;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordAPI;

public static partial class Bot
{
	public static string Token { get; private set; } = string.Empty;

	public static void Load()
	{
		var path = FileSystem.OrganizationData;

		if ( !path.FileExists( "discord_bot_token.txt" ) )
			path.WriteAllText( "discord_bot_token.txt", "PUT TOKEN HERE" );
		else
			Token = path.ReadAllText( "discord_bot_token.txt" );
	}

	public static async Task<List<Message>> GetChannelMessages( long channelid ) => await Channel.GetMessages( channelid );
	public static async Task<Message> GetChannelMessage( long channelid, long messageid ) => await Channel.GetMessage( channelid, messageid );

	/*[ConCmd.Server]
	public static void GetChannelMessages( int channelid )
	{
		List<Message> Messages = GetChannelMessages( 454245554 ).Result;
		Log.Info( Messages );

		foreach(var msg in Messages )
		{
			Log.Info( $"{msg.Content} \n {msg.Author}" );
		}
	}*/
}
