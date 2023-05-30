using Discord.Enums;
using Discord.Models;
using Discord.Utility;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Discord;

public partial class Client
{
	[Net] public bool IsWebsocketConnected { get; set; }
	[Net] private bool _IsClientLogged { get; set; }
	private static WebSocket WebSocket;
	private static TimeSince TimeSinceConnectionAttempt;

	private async Task EnsureWebSocket()
	{
		Game.AssertServer();

		if ( WebSocket?.IsConnected ?? false ) return;

		if ( TimeSinceConnectionAttempt < 2f )
		{
			await Task.Delay( 2000 );

			if ( WebSocket?.IsConnected ?? false ) return;
		}

		TimeSinceConnectionAttempt = 0f;
		WebSocket?.Dispose();
		WebSocket = new();
		WebSocket.OnMessageReceived += WebSocket_OnMessageReceived;
		WebSocket.OnDisconnected += WebSocket_OnDisconnected;
		await WebSocket.Connect( "wss://gateway.discord.gg/" );

		IsWebsocketConnected = WebSocket.IsConnected;
	}

	[ConCmd.Server]
	public static void CloseConnection()
	{
		WebSocket?.Dispose();
	}

	public static bool IsClientLogged() => Instance._IsClientLogged; 

	public static async Task Login()
	{
		if ( !WebSocket.IsConnected )
			return;
		
		var payload = new Payload
		{
			OPCode = (int)OPCodeTypes.IDENTIFY,
			Data = new IdentifyStructure()
		};
		
		path.WriteJson( "discord_payload_logs.json", payload );

		await WebSocket.Send( JsonUtility.Serialize( payload ) );
	}

	private void WebSocket_OnMessageReceived( string message )
	{
		var payload = JsonUtility.Deserialize<Payload>( message );
		if ( payload == null )
			return;
		
		switch( (OPCodeTypes)payload.OPCode )
		{
			case OPCodeTypes.DISPATCH:
			{
				switch( payload.EventName)
				{
					case "READY":
					{
						Event.Run( OnLogin );
						_IsClientLogged = true;
						
						break;
					}
					case "CHANNEL_CREATE":
					{
						var ChannelObject = JsonUtility.Deserialize<Channel>( payload.Data.ToString() );

						Event.Run( OnChannelCreate, ChannelObject );
						
						break;
					}
					case "CHANNEL_UPDATE":
					{
						var ChannelObject = JsonUtility.Deserialize<Channel>( payload.Data.ToString() );

						Event.Run( OnChannelUpdate, ChannelObject );
						
						break;
					}
					case "CHANNEL_DELETE":
					{
						var ChannelObject = JsonUtility.Deserialize<Channel>( payload.Data.ToString() );

						Event.Run( OnChannelDelete, ChannelObject );
						
						break;
					}
					case "MESSAGE_CREATE":
					{
						var MessageObject = JsonUtility.Deserialize<Message>( payload.Data.ToString() );

						Event.Run( OnMessageCreate, MessageObject );
						break;
					}
					case "MESSAGE_UPDATE":
					{
						var MessageObject = JsonUtility.Deserialize<Message>( payload.Data.ToString() );

						Event.Run( OnMessageUpdate, MessageObject );
						break;
					}
					case "MESSAGE_DELETE":
					{
						var MessageObject = JsonUtility.Deserialize<Message>( payload.Data.ToString() );

						Event.Run( OnMessageDelete, MessageObject );
						break;
					}
					case "MESSAGE_DELETE_BULK":
					{
						var MessageObject = JsonUtility.Deserialize<List<Message>>( payload.Data.ToString() );

						Event.Run( OnMessageDeleteBulk, MessageObject );
						break;
					}
					case "GUILD_CREATE":
					{
						var GuildObject = JsonUtility.Deserialize<Guild>( payload.Data.ToString() );

						Event.Run( OnGuildCreate, GuildObject );
						break;
					}
					case "GUILD_UPDATE":
					{
						var GuildObject = JsonUtility.Deserialize<Guild>( payload.Data.ToString() );

						Event.Run( OnGuildUpdate, GuildObject );
						break;
					}
					case "GUILD_DELETE":
					{
						var GuildObject = JsonUtility.Deserialize<Guild>( payload.Data.ToString() );

						Event.Run( OnGuildDelete, GuildObject );
						break;
					}
					case "GUILD_MEMBER_ADD":
					{
						var GuildMemberObject = JsonUtility.Deserialize<GuildMember>( payload.Data.ToString() );

						Event.Run( OnGuildMemberAdd, GuildMemberObject );
						break;
					}
					case "GUILD_MEMBER_UPDATE":
					{
						var GuildMemberObject = JsonUtility.Deserialize<GuildMember>( payload.Data.ToString() );

						Event.Run( OnGuildMemberUpdate, GuildMemberObject );
						break;
					}
					case "GUILD_MEMBER_REMOVE":
					{
						var GuildMemberObject = JsonUtility.Deserialize<GuildMember>( payload.Data.ToString() );

						Event.Run( OnGuildMemberRemove, GuildMemberObject );
						break;
					}
					case "GUILD_ROLE_CREATE":
					{
						var GuildRoleObject = JsonUtility.Deserialize<GuildRole>( payload.Data.ToString() );

						Event.Run( OnGuildRoleCreate, GuildRoleObject );
						break;
					}
					case "GUILD_ROLE_UPDATE":
					{
						var GuildRoleObject = JsonUtility.Deserialize<GuildRole>( payload.Data.ToString() );

						Event.Run( OnGuildRoleUpdate, GuildRoleObject );
						break;
					}
					case "GUILD_ROLE_DELETE":
					{
						var GuildRoleObject = JsonUtility.Deserialize<GuildRole>( payload.Data.ToString() );

						Event.Run( OnGuildRoleDelete, GuildRoleObject );
						break;
					}
					case "GUILD_BAN_ADD":
					{
						var GuildBanOject = JsonUtility.Deserialize<GuildMember>( payload.Data.ToString() );

						Event.Run( OnGuildBanAdd, GuildBanOject );
						break;
					}
					case "GUILD_BAN_REMOVE":
					{
						var GuildBanOject = JsonUtility.Deserialize<GuildMember>( payload.Data.ToString() );

						Event.Run( OnGuildBanRemove, GuildBanOject );
						break;
					}
					case "GUILD_EMOJIS_UPDATE":
					{
						var GuildEmojiObject = JsonUtility.Deserialize<GuildEmojiUpdate>( payload.Data.ToString() );

						Event.Run( OnGuildBanRemove, GuildEmojiObject );
						break;
					}
					case "GUILD_MEMBERS_CHUNK":
					{
						var GuildEmojiObject = JsonUtility.Deserialize<GuildMembersChunk>( payload.Data.ToString() );

						Event.Run( OnGuildMembersChunk, GuildEmojiObject );
						break;
					}
					case "WEBHOOKS_UPDATE":
					{
						var WebhookUpdateObject = JsonUtility.Deserialize<GuildWebhookUpdate>( payload.Data.ToString() );

						Event.Run( OnWebhooksUpdate, WebhookUpdateObject );
						break;
					}
					case "TYPING_START":
					{
						var TypingStartObject = JsonUtility.Deserialize<GuildTypingStart>( payload.Data.ToString() );

						Event.Run( OnTypingStart, TypingStartObject );
						break;
					}
					case "PRESENCE_UPDATE":
					{
						var PresenceObject = JsonUtility.Deserialize<GuildPresence>( payload.Data.ToString() );

						Event.Run( OnPresenceUpdate, PresenceObject );
						break;
					}
					case "VOICE_STATE_UPDATE":
					{
						var VoiceStateObject = JsonUtility.Deserialize<VoiceState>( payload.Data.ToString() );

						Event.Run( OnVoiceStateUpdate, VoiceStateObject );
						break;
					}
					case "VOICE_SERVER_UPDATE":
					{
						var VoiceServerObject = JsonUtility.Deserialize<GuildVoiceServerUpdate>( payload.Data.ToString() );

						Event.Run( OnVoiceServerUpdate, VoiceServerObject );
						break;
					}
					case "INTERACTION_CREATE":
					{
						var InteractionObject = JsonUtility.Deserialize<GuildInteractionCreate>( payload.Data.ToString() );

						Event.Run( OnInteractionCreate, InteractionObject );
						break;
					}
				}
				break;
			}
			case OPCodeTypes.INVALID_SESSION:
			{
				Event.Run( OnInvalidSession );
				_IsClientLogged = false;
				break;
			}
			case OPCodeTypes.HELLO:
			{
				Event.Run( OnConnect );

				var structure = JsonUtility.Deserialize<ConnectStructure>( payload.Data.ToString() );
				if ( structure != null )
					HeartbeatInterval = structure.Heartbeat_Interval / 1000;

				break;
			}
			case OPCodeTypes.HEARTBACK_ACK: {
				Event.Run( OnHeartbeatACK );
				
				break;
			}
		}
	}

	private void WebSocket_OnDisconnected(int status, string reason)
	{
		Event.Run( OnDisconnect, reason );
		_IsClientLogged = false;
	}
}
