using System.Text.Json.Serialization;

namespace Discord.Models;

public partial class DefaultReaction : BaseNetworkable
{
	/// <summary>
	/// The id of a guild's custom emoji
	/// </summary>
	[JsonPropertyName( "emoji_id" )]
	[Net] public string Emoji_ID { get; set; }

	/// <summary>
	/// The unicode character of the emoji
	/// </summary>
	[JsonPropertyName( "emoji_name" )]
	[Net] public string Emoji_Name { get; set; } = string.Empty;
}
