using Mbk.Discord.Models;
using System.ComponentModel.DataAnnotations;

namespace Mbk.Discord;

[Library( Title = "Client" )]
[Display( Name = "Client" ), Category( "Discord" ), Icon( "smart_toy" )]
public partial class Client : Entity
{
	public static Client Instance { get; private set; }
	private static BaseFileSystem path => FileSystem.Data;

	/// <summary>
	///	The current bot token
	/// </summary>
	[Net, Change, Local, HideInEditor] public string Token { get; set; }

	/// <summary>
	///	Is token valid or not
	/// </summary>
	[Net] public bool TokenValid { get; private set; } = false;

	public void OnTokenChanged( string oldValue, string newValue )
	{
		TokenValid = IsRegexValid( newValue );

		if( TokenValid )
			_ = Login();
	}

	public Client()
	{
		Instance = this;
		Transmit = TransmitType.Always;

		if ( Game.IsServer )
		{
			if ( !path.FileExists( "discord_bot_token.txt" ) )
				path.WriteAllText( "discord_bot_token.txt", "PUT TOKEN HERE" );
			else
				SetToken( path.ReadAllText( "discord_bot_token.txt" ) );

			_ = EnsureWebSocket();
		}
	}

	[ConCmd.Server]
	public static void SetToken( string _token )
	{
		Instance.Token = _token;
		Instance.TokenValid = IsTokenValid();
		if ( Instance.TokenValid )
		{
			path.WriteAllText( "discord_bot_token.txt", _token );
		}
	}

	
	[OnConnect]
	public static void OnConnectEvent()
	{
		Log.Info( "[DISCORD-SOCKET] The websocket connection has been etablished." );
		_ = Login();
	}

	[OnInvalidSession]
	public static void OnInvalidSessionEvent()
	{
		Log.Info( "[DISCORD-SOCKET] The websocket connection has been invalidated, please retry." );
	}

	[OnLogin]
	public static void OnLoginEvent()
	{
		Log.Info( "[DISCORD-SOCKET] The bot connection has been etablished." );
	}

	[OnHeartbeatACK]
	public static void OnHeartbeatACKEvent()
	{
		Log.Info( "[DISCORD-SOCKET] Heartbeat ACK received, connection still LIVE." );
	}

	[OnDisconnect]
	public static void OnDisconnectEvent( string reason )
	{
		Log.Info( $"[DISCORD-SOCKET] The websocket has been disconnected ({reason})" );
	}

	[OnChannelCreate]
	public static void OnChannelCreateEvent( Channel channel )
	{
		Log.Info( $"[DISCORD-SOCKET] New channel {channel.Name} - {channel.Id}" );
	}

	[OnChannelUpdate]
	public static void OnChannelUpdateEvent( Channel channel )
	{
		Log.Info( $"[DISCORD-SOCKET] Updated channel {channel.Name} - {channel.Id}" );
	}

	[OnChannelDelete]
	public static void OnChannelDeleteEvent( Channel channel )
	{
		Log.Info( $"[DISCORD-SOCKET] Deleted channel {channel.Name} - {channel.Id}" );
	}

	[OnMessageCreate]
	public static void OnMessageCreateEvent( Message message )
	{
		Log.Info( $"[DISCORD-SOCKET] New message {message.Content} - {message.Id}" );
	}

	[OnMessageUpdate]
	public static void OnMessageUpdateEvent( Message message )
	{
		Log.Info( $"[DISCORD-SOCKET] Updated message {message.Content}" );
	}

	[OnMessageDelete]
	public static void OnMessageDeleteEvent( Message message )
	{
		Log.Info( $"[DISCORD-SOCKET] Delete message {message.Content}" );
	}

	[OnMessageDeleteBulk]
	public static void OnMessageDeleteBulkEvent( List<Message> messages )
	{
		foreach ( var msg in messages )
		{
			Log.Info( $"[DISCORD-SOCKET] Deleted message {msg.Content}" );
		}
	}

	[OnGuildCreate]
	public static void OnGuildCreateEvent( Guild guild )
	{
		Log.Info( $"[DISCORD-SOCKET] Guild created [{guild.Members.Count}]" );

		Instance.Guild = guild;

		Log.Info( guild.JoinedAt );
		Log.Info( guild.Name );
		Log.Info( guild.Channels.Count );

		foreach ( var channel in guild.Channels )
		{
			Log.Info( channel.Name );
		}

		foreach ( var member in guild.Members )
		{
			Log.Info( member.User.Username );
		}
	}

	[OnGuildUpdate]
	public static void OnGuildUpdateEvent( Guild guild )
	{
		Log.Info( $"[DISCORD-SOCKET] Guild updated [{guild.Id}]" );
	}

	[OnGuildDelete]
	public static void OnGuildDeleteEvent( Guild guild )
	{
		Log.Info( $"[DISCORD-SOCKET] Guild deleted [{guild.Id}]" );
	}
}
