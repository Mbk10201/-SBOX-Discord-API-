using Mbk.Discord.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildTypingStart
{
	/// <summary>
	/// The guild id where the a client started typing (optional)
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The channel ID where the user started typing
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; } = null;

	/// <summary>
	/// The user ID which started typing
	/// </summary>
	[JsonPropertyName( "user_id" )]
	public object UserID { get; set; } = null;

	/// <summary>
	/// The timestamp when the user started typing
	/// </summary>
	[JsonPropertyName( "timestamp" )]
	public object Timestamp { get; set; } = null;
}
