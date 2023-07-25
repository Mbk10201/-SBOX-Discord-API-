using Mbk.Discord.Attributes;
using Mbk.Discord.Models;

namespace Mbk.Discord;

public static class GameEvents
{
	[DiscordGameEvent( "Client Joined", "client_joined", "When a client join the server" )]
	[GameEvent.Server.ClientJoined]
	public static void ClientJoined( ClientJoinedEvent e )
	{
		var EventSettings = DiscordSystem.GetGameEvent( "client_joined" );

		if ( !EventSettings.Broadcast )
			return;

		var message = new MessageForm();

		if ( EventSettings.DisplayEmbed )
		{
			message = new()
			{
				Embeds = new()
				{
					new Embed()
					{
						Title = EventSettings.Name,
						Description = $"{e.Client.Name} joined the server.",
						Color = EventSettings.GetColor()
					}
				}
			};
		}
		else
		{
			message = new()
			{
				Content = $"{e.Client.Name} joined the server."
			};
		}

		if ( EventSettings.UseAsBot && Client.Instance.TokenValid )
		{
			if ( EventSettings.ChannelID is null )
				return;

			Client.SendMessage( EventSettings.ChannelID.Value, message );
		}
		else
		{
			if ( EventSettings.Webhook == string.Empty )
				return;

			Webhook.SendMessage( EventSettings.Webhook, message );
		}
	}

	[DiscordGameEvent( "Client Disconnect", "client_disconnect", "When a client leave the server" )]
	[GameEvent.Server.ClientDisconnect]
	public static void ClientDisconnect( ClientDisconnectEvent e )
	{
		var EventSettings = DiscordSystem.GetGameEvent( "client_joined" );

		if ( !EventSettings.Broadcast )
			return;

		var message = new MessageForm();

		if ( EventSettings.DisplayEmbed )
		{
			message = new()
			{
				Embeds = new()
				{
					new Embed()
					{
						Title = EventSettings.Name,
						Description = $"{e.Client.Name} has disconnected from the server.",
						Color = EventSettings.GetColor()
					}
				}
			};
		}
		else
		{
			message = new()
			{
				Content = $"{e.Client.Name} has disconnected from the server"
			};
		}

		if ( EventSettings.UseAsBot && Client.Instance.TokenValid )
		{
			if ( EventSettings.ChannelID is null )
				return;

			Client.SendMessage( EventSettings.ChannelID.Value, message );
		}
		else
		{
			if ( EventSettings.Webhook == string.Empty )
				return;

			Webhook.SendMessage( EventSettings.Webhook, message );
		}
	}

	[DiscordGameEvent( "Hotload", "hotload_debug", "When the server hotloads on debug" )]
	[Event.Hotload]
	public static void Hotload()
	{
		var EventSettings = DiscordSystem.GetGameEvent( "hotload_debug" );

		if ( !EventSettings.Broadcast )
			return;

		var message = new MessageForm();

		if ( EventSettings.DisplayEmbed )
		{
			message = new()
			{
				Embeds = new()
				{
					new Embed()
					{
						Title = EventSettings.Name,
						Description = $"The server has been refreshed [HOTLOAD]",
						Color = EventSettings.GetColor()
					}
				}
			};
		}
		else
		{
			message = new()
			{
				Content = $"The server has been refreshed [HOTLOAD]"
			};
		}

		if ( EventSettings.UseAsBot && Client.Instance.TokenValid )
		{
			if ( EventSettings.ChannelID is null )
				return;

			Client.SendMessage( EventSettings.ChannelID.Value, message );
		}
		else
		{
			if ( EventSettings.Webhook == string.Empty )
				return;

			Webhook.SendMessage( EventSettings.Webhook, message );
		}
	}
}

