using DiscordAPI.Models;
using Sandbox;
using System.Collections.Generic;
using System.Linq;

namespace DiscordAPI;

public static partial class Discord
{
	[RegisterDiscordEvent("Client Joined", "client_joined", "When a client join the server", "auth")]
	[GameEvent.Server.ClientJoined]
	public static void ClientJoined( ClientJoinedEvent e )
	{
		var EventSettings = EventList.Single( x => x.Identifier == "client_joined" );

		if ( !EventSettings.Broadcast )
			return;

		if ( EventSettings.DisplayEmbed )
		{
			var message = new MessageForm()
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

			if (EventSettings.UseAsBot && Bot.IsTokenValid())
			{
				Bot.SendMessage( EventSettings.ChannelID.Value, message);
			}
			else
			{
				if ( EventSettings.Webhook == string.Empty )
					return;
				
				Webhook.SendMessage( EventSettings.Webhook, message);
			}
		}
		else
		{
			var message = new MessageForm()
			{
				Content = $"{e.Client.Name} joined the server."
			};

			if ( EventSettings.UseAsBot && Bot.IsTokenValid() )
			{
				Bot.SendMessage( EventSettings.ChannelID.Value, message);
			}
			else
			{
				if ( EventSettings.Webhook == string.Empty )
					return;

				Webhook.SendMessage( EventSettings.Webhook, message );
			}
		}
	}

	[RegisterDiscordEvent( "Client Disconnect", "client_disconnect", "When a client leave the server", "auth" )]
	[GameEvent.Server.ClientDisconnect]
	public static void ClientDisconnect( ClientDisconnectEvent e )
	{
		var EventSettings = EventList.Single( x => x.Identifier == "client_joined" );

		if ( !EventSettings.Broadcast )
			return;

		if ( EventSettings.DisplayEmbed )
		{
			var message = new MessageForm()
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

			if ( EventSettings.UseAsBot && Bot.IsTokenValid() )
			{
				Bot.SendMessage( EventSettings.ChannelID.Value, message );
			}
			else
			{
				if ( EventSettings.Webhook == string.Empty )
					return;

				Webhook.SendMessage( EventSettings.Webhook, message );
			}
		}
		else
		{
			var message = new MessageForm()
			{
				Content = $"{e.Client.Name} has disconnected from the server"
			};

			if ( EventSettings.UseAsBot && Bot.IsTokenValid() )
			{
				Bot.SendMessage( EventSettings.ChannelID.Value, message );
			}
			else
			{
				if ( EventSettings.Webhook == string.Empty )
					return;

				Webhook.SendMessage( EventSettings.Webhook, message );
			}
		}
	}
}
