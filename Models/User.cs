using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public partial class User : BaseNetworkable
{
	// https://discord.com/developers/docs/resources/user#user-object

	/// <summary>
	/// The user's id
	/// </summary>
	[JsonPropertyName( "id" )]
	[Net] public string Id { get; set; }

	/// <summary>
	/// The user's username, not unique across the platform
	/// </summary>
	[JsonPropertyName( "username" )]
	[Net] public string Username { get; set; }

	/// <summary>
	/// The user's 4-digit discord-tag
	/// </summary>
	[JsonPropertyName( "discriminator" )]
	[Net] public string Discriminator { get; set; }

	/// <summary>
	/// The user's avatar hash
	/// </summary>
	[JsonPropertyName( "avatar" )]
	[Net] public string Avatar { get; set; } = string.Empty;

	/// <summary>
	/// Whether the user belongs to an OAuth2 application
	/// </summary>
	[JsonPropertyName( "bot" )]
	[Net] public bool? IsBot { get; set; }

	/// <summary>
	/// Whether the user is an Official Discord System user (part of the urgent message system)
	/// </summary>
	[JsonPropertyName( "system" )]
	[Net] public bool? IsSystem { get; set; }

	/// <summary>
	/// Whether the user has two factor enabled on their account
	/// </summary>
	[JsonPropertyName( "mfa_enabled" )]
	[Net] public bool? HasMFA { get; set; }

	/// <summary>
	/// The user's banner hash
	/// </summary>
	[JsonPropertyName( "banner" )]
	[Net] public string Banner { get; set; } = string.Empty;

	/// <summary>
	/// The user's banner color encoded as an integer representation of hexadecimal color code
	/// </summary>
	[JsonPropertyName( "accent_color" )]
	[Net] public int? AccentColor { get; set; }

	/// <summary>
	/// The user's chosen language option
	/// </summary>
	[JsonPropertyName( "locale" )]
	[Net] public string Locale { get; set; } = string.Empty;

	/// <summary>
	/// Whether the email on this account has been verified
	/// </summary>
	[JsonPropertyName( "verified" )]
	[Net] public bool? IsVerified { get; set; }

	/// <summary>
	/// The user's email
	/// </summary>
	[JsonPropertyName( "email" )]
	[Net] public string Email { get; set; } = string.Empty;

	/// <summary>
	/// The flags on a user's account
	/// </summary>
	[JsonPropertyName( "flags" )]
	[Net] public UserFlags? Flags { get; set; }

	/// <summary>
	/// The type of Nitro subscription on a user's account
	/// </summary>
	[JsonPropertyName( "premium_type" )]
	[Net] public PremiumTypes? PremiumType { get; set; }

	/// <summary>
	/// The public flags on a user's account
	/// </summary>
	[JsonPropertyName( "public_flags" )]
	[Net] public UserFlags? PublicFlags { get; set; }
}
