using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Emoji
{
	// According to the discord docs (https://discord.com/developers/docs/resources/emoji)

	/// <summary>
	/// Emoji id
	/// </summary>
	[JsonPropertyName( "id" )]
	public object Id { get; set; } = null;

	/// <summary>
	/// Emoji name
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Roles allowed to use this emoji
	/// </summary>
	[JsonPropertyName( "roles" )]
	public List<Role> Roles { get; set; } = null;

	/// <summary>
	/// User that created this emoji
	/// </summary>
	[JsonPropertyName( "user" )]
	public User User { get; set; } = null;

	/// <summary>
	/// Whether this emoji must be wrapped in colons
	/// </summary>
	[JsonPropertyName( "require_colons" )]
	public bool? RequireColons { get; set; }

	/// <summary>
	/// Whether this emoji is managed
	/// </summary>
	[JsonPropertyName( "managed" )]
	public bool? Managed { get; set; }

	/// <summary>
	/// Whether this emoji is animated
	/// </summary>
	[JsonPropertyName( "animated" )]
	public bool? Animated { get; set; }

	/// <summary>
	/// Whether this emoji can be used, may be false due to loss of Server Boosts
	/// </summary>
	[JsonPropertyName( "available" )]
	public bool? Available { get; set; }
}
