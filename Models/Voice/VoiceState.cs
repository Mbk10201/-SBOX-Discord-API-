using DiscordAPI.Enums;
using Sandbox;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class VoiceState
{
	/// <summary>
	/// The guild id this voice state is for
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public long? GuildID { get; set; }

	/// <summary>
	/// The channel id this user is connected to
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public long? ChannelID { get; set; }

	/// <summary>
	/// The channel id this user is connected to
	/// </summary>
	[JsonPropertyName( "user_id" )]
	public long UserID { get; set; }

	/// <summary>
	/// The guild member this voice state is for
	/// </summary>
	[JsonPropertyName( "member" )]
	public GuildMember Member { get; set; } = null;

	/// <summary>
	/// The session id for this voice state
	/// </summary>
	[JsonPropertyName( "member" )]
	public string SessionID { get; set; }

	/// <summary>
	/// Whether this user is deafened by the server
	/// </summary>
	[JsonPropertyName( "deaf" )]
	public bool Deaf { get; set; }

	/// <summary>
	/// Whether this user is muted by the server
	/// </summary>
	[JsonPropertyName( "mute" )]
	public bool Mute { get; set; }

	/// <summary>
	/// Whether this user is locally deafened
	/// </summary>
	[JsonPropertyName( "self_deaf" )]
	public bool SelfDeaf { get; set; }

	/// <summary>
	/// Whether this user is locally muted
	/// </summary>
	[JsonPropertyName( "self_mute" )]
	public bool SelfMute { get; set; }

	/// <summary>
	/// Whether this user is streaming using "Go Live"
	/// </summary>
	[JsonPropertyName( "self_stream" )]
	public bool SelfStream { get; set; } = false;

	/// <summary>
	/// Whether this user's camera is enabled
	/// </summary>
	[JsonPropertyName( "self_video" )]
	public bool SelfVideo { get; set; }

	/// <summary>
	/// whether this user's permission to speak is denied
	/// </summary>
	[JsonPropertyName( "suppress" )]
	public bool Suppress { get; set; }

	/// <summary>
	/// The time at which the user requested to speak
	/// </summary>
	[JsonPropertyName( "request_to_speak_timestamp" )]
	public RealTimeSince RequestToSpeak { get; set; }
}
