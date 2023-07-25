namespace Mbk.Discord.Enums;

public enum OPCodeTypes
{
	/// <summary>
	/// Dispatches an event
	/// </summary>
	DISPATCH = 0,

	/// <summary>
	/// Used for ping checking
	/// </summary>
	HEARTBEAT = 1,

	/// <summary>
	/// Used for client handshake
	/// </summary>
	IDENTIFY = 2,

	/// <summary>
	/// Used to update the client status
	/// </summary>
	STATUS_UPDATE = 3,

	/// <summary>
	/// Used to join/move/leave voice channels
	/// </summary>
	VOICE_STATE_UPDATE = 4,

	/// <summary>
	/// Used for voice ping checking
	/// </summary>
	VOICE_SERVER_PING = 5,

	/// <summary>
	/// Used to resume a closed connection
	/// </summary>
	RESUME = 6,

	/// <summary>
	/// Used to tell clients to reconnect to the gateway
	/// </summary>
	RECONNECT = 7,

	/// <summary>
	/// Used to request guild members
	/// </summary>
	REQUEST_GUILD_MEMBERS = 8,

	/// <summary>
	/// Used to request guild members
	/// </summary>
	INVALID_SESSION = 9,

	/// <summary>
	/// Sent immediately after connecting, contains heartbeat and server debug information
	/// </summary>
	HELLO = 10,

	/// <summary>
	/// Sent immediately following a client heartbeat that was received
	/// </summary>
	HEARTBACK_ACK = 11,
}
