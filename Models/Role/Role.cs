using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public partial class Role : BaseNetworkable
{
	/// <summary>
	///	Role id
	/// </summary>
	[JsonPropertyName("id")] 
	[Net] public string Id { get; set; }

	/// <summary>
	///	Role name
	/// </summary>
	[JsonPropertyName( "name" )]
	[Net] public string Name { get; set; } = null;

	/// <summary>
	///	Integer representation of hexadecimal color code
	/// </summary>
	[JsonPropertyName( "color" )]
	[Net] public int? Color { get; set; }

	/// <summary>
	///	If this role is pinned in the user listing
	/// </summary>
	[JsonPropertyName( "hoist" )]
	[Net] public bool? Hoist { get; set; }

	/// <summary>
	///	Role icon hash
	/// </summary>
	[JsonPropertyName( "icon" )]
	[Net] public string Icon { get; set; } = string.Empty;

	/// <summary>
	///	Role unicode emoji
	/// </summary>
	[JsonPropertyName( "unicode_emoji" )]
	[Net] public string UnicodeEmoji { get; set; } = string.Empty;

	/// <summary>
	///	Position of this role
	/// </summary>
	[JsonPropertyName( "position" )]
	[Net] public int? Position { get; set; }

	/// <summary>
	///	Permission bit set
	/// </summary>
	[JsonPropertyName( "permissions" )]
	[Net] public ulong Permissions { get; set; }

	/// <summary>
	///	Whether this role is managed by an integration
	/// </summary>
	[JsonPropertyName( "managed" )]
	[Net] public bool? Managed { get; set; }

	/// <summary>
	///	Whether this role is mentionable
	/// </summary>
	[JsonPropertyName( "mentionable" )]
	[Net] public bool? Mentionable { get; set; }

	/// <summary>
	///	The tags this role has
	/// </summary>
	[JsonPropertyName( "tags" )]
	[Net] public RoleTag Tags { get; set; } = null;
}
