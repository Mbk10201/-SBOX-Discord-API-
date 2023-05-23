using DiscordAPI.Models;
using Sandbox;

namespace DiscordAPI;

public partial class DiscordAPI
{
	[GameEvent.Server.ClientJoined]
	public static void ClientJoined( ClientJoinedEvent e )
	{
		if ( !Settings.PlayerJoinEvent )
			return;

		if( Settings.AsEmbed )
		{
			if(API.IsTokenValid())
			{
				Bot.SendMessage( 1110259447256842332, new MessageForm()
				{
					Embeds = new()
					{
						new Embed()
						{
							Title = "Event Notification",
							Description = $"{e.Client.Name} joined the server.",
							Color = 12713984
						}
					}
				} );
			}
			else
			{
				Webhook.SendMessage( "https://discord.com/api/webhooks/1110297586721620020/oQfXNWLn0SgB4AtkGd2_1k28jtgPoP7G1dN9Gq3z_3sc54EIERDHtAQ7PQxhV3FU7fMY", new MessageForm()
				{
					Embeds = new()
					{
						new Embed()
						{
							Title = "Event Notification",
							Description = $"{e.Client.Name} joined the server.",
							Color = 12713984
						}
					}
				} );
			}
		}
		else
		{
			if ( API.IsTokenValid() )
			{
				Bot.SendMessage( 1110259447256842332, new MessageForm()
				{
					Content = $"{e.Client.Name} joined the server."
				} );
			}
			else
			{
				Webhook.SendMessage( "https://discord.com/api/webhooks/1110297586721620020/oQfXNWLn0SgB4AtkGd2_1k28jtgPoP7G1dN9Gq3z_3sc54EIERDHtAQ7PQxhV3FU7fMY", new MessageForm()
				{
					Content = $"{e.Client.Name} joined the server."
				} );
			}
		}
	}

	[GameEvent.Server.ClientDisconnect]
	public static void ClientDisconnect( ClientDisconnectEvent e )
	{
		if ( !Settings.PlayerJoinEvent )
			return;

		if ( Settings.AsEmbed )
		{
			if ( API.IsTokenValid() )
			{
				Bot.SendMessage( 1110259447256842332, new MessageForm()
				{
					Embeds = new()
					{
						new Embed()
						{
							Title = "Event Notification",
							Description = $"{e.Client.Name} joined the server.",
							Color = 12713984
						}
					}
				} );
			}
			else
			{
				Webhook.SendMessage( "https://discord.com/api/webhooks/1110297586721620020/oQfXNWLn0SgB4AtkGd2_1k28jtgPoP7G1dN9Gq3z_3sc54EIERDHtAQ7PQxhV3FU7fMY", new MessageForm()
				{
					Embeds = new()
					{
						new Embed()
						{
							Title = "Event Notification",
							Description = $"{e.Client.Name} joined the server.",
							Color = 12713984
						}
					}
				} );
			}
		}
		else
		{
			if ( API.IsTokenValid() )
			{
				Bot.SendMessage( 1110259447256842332, new MessageForm()
				{
					Content = $"{e.Client.Name} joined the server."
				} );
			}
			else
			{
				Webhook.SendMessage( "https://discord.com/api/webhooks/1110297586721620020/oQfXNWLn0SgB4AtkGd2_1k28jtgPoP7G1dN9Gq3z_3sc54EIERDHtAQ7PQxhV3FU7fMY", new MessageForm()
				{
					Content = $"{e.Client.Name} joined the server."
				} );
			}
		}
	}
}
