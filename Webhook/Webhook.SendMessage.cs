using DiscordAPI.Models;
using DiscordAPI.Utility;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordAPI;

public partial class Webhook
{
	/// <summary>
	/// Send a message to a discord server channel through a webhook
	/// <param name="webhook">The webhook url</param>
	/// <param name="message">The message object</param>
	/// </summary>
	public async void SendMessage( string webhook, MessageForm message )
	{
		await Send(webhook, message);
	}

	private static async Task Send( string webhook, MessageForm message )
	{
		Dictionary<string, string> headers = new()
		{
			{ "Content-Type", "application/json" },
		};
		
		using var response = await API.Post( webhook, message, headers);
		response.EnsureSuccessStatusCode();
	}
}
