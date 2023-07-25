using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Reaction
{
	/// <summary>
	/// Times this emoji has been used to react
	/// </summary>
	[JsonPropertyName( "count" )]
	public int Count { get; set; }

	/// <summary>
	/// Whether the current user reacted using this emoji
	/// </summary>
	[JsonPropertyName( "me" )]
	public bool Me { get; set; }

	/// <summary>
	/// Emoji information
	/// </summary>
	[JsonPropertyName( "emoji" )]
	public Emoji Emoji { get; set; }
}
