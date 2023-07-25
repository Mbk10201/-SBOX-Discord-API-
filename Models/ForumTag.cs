using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public partial class ForumTag : BaseNetworkable
{
	/// <summary>
	/// The id of the tag
	/// </summary>
	[JsonPropertyName( "id" )]
	[Net] public string Id { get; set; }

	/// <summary>
	/// The name of the tag (0-20 characters)
	/// </summary>
	[JsonPropertyName( "name" )]
	[Net] public string Name { get; set; }

	/// <summary>
	/// Whether this tag can only be added to or removed from threads by a member with the MANAGE_THREADS permission
	/// </summary>
	[JsonPropertyName( "moderated" )]
	[Net] public bool Moderated { get; set; }

	/// <summary>
	/// The id of a guild's custom emoji *
	/// </summary>
	[JsonPropertyName( "emoji_id" )]
	[Net] public string Emoji_ID { get; set; }

	/// <summary>
	/// The unicode character of the emoji *
	/// </summary>
	[JsonPropertyName( "emoji_name" )]
	[Net] public string Emoji_Name { get; set; } = string.Empty;

}
