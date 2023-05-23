using DiscordAPI.Models;
using Sandbox;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordAPI;

public partial class Bot
{
	public static Bot Instance { get; private set; }
	public string Token { get; private set; }

	public Bot( string _token = "" )
	{
		Instance = this;
		Token = _token;
	}

	public static Dictionary<string, string> GetHeaders() => new ()
	{
		{ "Content-Type", "application/json" },
		{ "Authorization", $"Bot {Instance.Token}" }
	};

	public static async Task<List<Message>> GetChannelMessages( long channelid ) => await Channel.GetMessages( channelid );
	public static async Task<Message> GetChannelMessage( long channelid, long messageid ) => await Channel.GetMessage( channelid, messageid );

	[ConCmd.Server]
	public static void GetChannelMessages()
	{
		List<Message> Messages = GetChannelMessages( 1110259447256842332 ).Result;
		Log.Info( Messages );

		foreach(var msg in Messages )
		{
			Log.Info( $"{msg.Content} \n {msg.Author}" );
		}
	}
}
