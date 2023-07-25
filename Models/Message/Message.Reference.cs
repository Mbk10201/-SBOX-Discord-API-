using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class MessageReference
{
	/// <summary>
	/// Id of the originating message
	/// </summary>
	[JsonPropertyName( "message_id" )]
	public long? MessageID { get; set; }

	/// <summary>
	///	Id of the originating message's channel
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public long? ChannelID { get; set; }

	/// <summary>
	/// Id of the originating message's guild
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public long? GuildID { get; set; }

	/// <summary>
	/// When sending, whether to error if the referenced message doesn't exist instead of sending as a normal (non-reply) message, default true
	/// </summary>
	[JsonPropertyName( "fail_if_not_exists" )]
	public bool? FailIfNotExists { get; set; }
}
