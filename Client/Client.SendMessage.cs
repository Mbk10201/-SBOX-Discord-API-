﻿using Mbk.Discord.Models;

namespace Mbk.Discord;

public partial class Client
{
	/// <summary>
	/// Send a message to a discord server channel by a ID
	/// <param name="channelid">The channelid</param>
	/// <param name="message">The message object</param>
	/// </summary>
	public static async void SendMessage( long channelid, MessageForm message )
	{
		await Send(channelid, message);
	}

	private static async Task Send( long channelid, MessageForm message )
	{
		if(!IsTokenValid( ) )
		{
			Log.Info( "[DISCORD-API] Bot token is null, please provide one to be able to send message" );
			return;
		}
		
		string destination = $"channels/{channelid}/messages";

		using var response = await Post( destination, message );
		response.EnsureSuccessStatusCode();
	}
}
