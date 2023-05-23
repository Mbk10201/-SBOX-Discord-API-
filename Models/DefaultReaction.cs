using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class DefaultReaction
{
	/// <summary>
	/// The id of a guild's custom emoji
	/// </summary>
	[JsonPropertyName( "emoji_id" )]
	public long? Emoji_ID { get; set; }

	/// <summary>
	/// The unicode character of the emoji
	/// </summary>
	[JsonPropertyName( "emoji_name" )]
	public string Emoji_Name { get; set; } = string.Empty;
}
