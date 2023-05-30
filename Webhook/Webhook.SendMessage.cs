using Discord.Models;

namespace Discord;

public static partial class Webhook
{
	/// <summary>
	/// Send a message to a discord server channel through a webhook
	/// <param name="webhook">The webhook url</param>
	/// <param name="message">The message object</param>
	/// </summary>
	public static async void SendMessage( string webhook, MessageForm message )
	{
		await Send(webhook, message);
	}

	private static async Task Send( string webhook, MessageForm message )
	{
		using var response = await Post( webhook, message );
		response.EnsureSuccessStatusCode();
	}
}
