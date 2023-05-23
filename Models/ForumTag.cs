using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class ForumTag
{
	/// <summary>
	/// The id of the tag
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// The name of the tag (0-20 characters)
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// Whether this tag can only be added to or removed from threads by a member with the MANAGE_THREADS permission
	/// </summary>
	[JsonPropertyName( "moderated" )]
	public bool Moderated { get; set; }

	/// <summary>
	/// The id of a guild's custom emoji *
	/// </summary>
	[JsonPropertyName( "emoji_id" )]
	public long? Emoji_ID { get; set; }

	/// <summary>
	/// The unicode character of the emoji *
	/// </summary>
	[JsonPropertyName( "emoji_name" )]
	public string Emoji_Name { get; set; } = string.Empty;

}
