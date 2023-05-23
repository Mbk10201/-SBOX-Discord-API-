using DiscordAPI.Models;
using DiscordAPI.Utility;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordAPI;

public partial class Bot
{
	/// <summary>
	/// Send a message to a discord server channel by a ID
	/// <param name="channelid">The channelid</param>
	/// <param name="message">The message object</param>
	/// </summary>
	public async void SendMessage( long channelid, MessageForm message )
	{
		await Send(channelid, message);
	}

	private static async Task Send( long channelid, MessageForm message )
	{
		if(!API.IsTokenValid())
		{
			Log.Info( "[DISCORD-API] Bot token is null, please provide one to be able to send message" );
			return;
		}
		
		string destination = $"channels/{channelid}/messages";

		using var response = await API.Post( $"{API.Discord_ApiPoint}/{destination}", message );
		response.EnsureSuccessStatusCode();
	}
}
