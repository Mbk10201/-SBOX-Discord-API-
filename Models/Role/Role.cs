using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class Role
{
	/// <summary>
	///	Role id
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	///	Role name
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	///	Integer representation of hexadecimal color code
	/// </summary>
	[JsonPropertyName( "color" )]
	public int Color { get; set; }

	/// <summary>
	///	If this role is pinned in the user listing
	/// </summary>
	[JsonPropertyName( "hoist" )]
	public bool Hoist { get; set; }

	/// <summary>
	///	Role icon hash
	/// </summary>
	[JsonPropertyName( "icon" )]
	public string Icon { get; set; } = string.Empty;

	/// <summary>
	///	Role unicode emoji
	/// </summary>
	[JsonPropertyName( "unicode_emoji" )]
	public string UnicodeEmoji { get; set; } = string.Empty;

	/// <summary>
	///	Position of this role
	/// </summary>
	[JsonPropertyName( "position" )]
	public int Position { get; set; }

	/// <summary>
	///	Permission bit set
	/// </summary>
	[JsonPropertyName( "permissions" )]
	public string Permissions { get; set; }

	/// <summary>
	///	Whether this role is managed by an integration
	/// </summary>
	[JsonPropertyName( "managed" )]
	public bool Managed { get; set; }

	/// <summary>
	///	Whether this role is mentionable
	/// </summary>
	[JsonPropertyName( "mentionable" )]
	public bool Mentionable { get; set; }

	/// <summary>
	///	The tags this role has
	/// </summary>
	[JsonPropertyName( "tags" )]
	public RoleTag Tags { get; set; } = null;
}
