using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Application
{
	// According to the discord doc (https://discord.com/developers/docs/resources/application#application-object)

	/// <summary>
	/// The id of the app
	/// </summary>
	[JsonPropertyName( "id" )]
	public object Id { get; set; }

	/// <summary>
	/// The name of the app
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// The icon hash of the app
	/// </summary>
	[JsonPropertyName( "icon" )]
	public string Icon { get; set; } = string.Empty;

	/// <summary>
	/// The description of the app
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; }

	/// <summary>
	/// An array of rpc origin urls, if rpc is enabled
	/// </summary>
	[JsonPropertyName( "rpc_origins" )]
	public List<string> RpcOrigins { get; set; } = null;

	/// <summary>
	/// When false only app owner can join the app's bot to guilds
	/// </summary>
	[JsonPropertyName( "bot_public" )]
	public bool BotPublic { get; set; }

	/// <summary>
	/// When true the app's bot will only join upon completion of the full oauth2 code grant flow
	/// </summary>
	[JsonPropertyName( "bot_require_code_grant" )]
	public bool BotRequireCodeGrant { get; set; }

	/// <summary>
	/// The url of the app's terms of service
	/// </summary>
	[JsonPropertyName( "terms_of_service_url" )]
	public string TermsOfServiceUrl { get; set; } = string.Empty;

	/// <summary>
	/// The url of the app's privacy policy
	/// </summary>
	[JsonPropertyName( "privacy_policy_url" )]
	public string PrivacyPolicyUrl { get; set; } = string.Empty;

	/// <summary>
	/// Partial user object containing info on the owner of the application
	/// </summary>
	[JsonPropertyName( "owner" )]
	public User Owner { get; set; } = null;

	/// <summary>
	/// The hex encoded key for verification in interactions and the GameSDK's GetTicket
	/// </summary>
	[JsonPropertyName( "verify_key" )]
	public string VerifyKey { get; set; }

	/// <summary>
	/// If the application belongs to a team, this will be a list of the members of that team
	/// </summary>
	[JsonPropertyName( "team" )]
	public Team Team { get; set; }

	/// <summary>
	/// If this application is a game sold on Discord, this field will be the guild to which it has been linked
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// If this application is a game sold on Discord, this field will be the id of the "Game SKU" that is created, if exists
	/// </summary>
	[JsonPropertyName( "primary_sku_id" )]
	public object PrimarySkuID { get; set; } = null;

	/// <summary>
	/// If this application is a game sold on Discord, this field will be the URL slug that links to the store page
	/// </summary>
	[JsonPropertyName( "slug" )]
	public string Slug { get; set; } = string.Empty;

	/// <summary>
	/// The application's default rich presence invite cover image hash
	/// </summary>
	[JsonPropertyName( "cover_image" )]
	public string CoverImage { get; set; } = string.Empty;

	/// <summary>
	/// The application's public flags
	/// </summary>
	[JsonPropertyName( "flags" )]
	public ApplicationFlags Flags { get; set; }

	/// <summary>
	/// Up to 5 tags describing the content and functionality of the application
	/// </summary>
	[JsonPropertyName( "tags" )]
	public List<string> Tags { get; set; } = null;

	/// <summary>
	/// Up to 5 tags describing the content and functionality of the application
	/// </summary>
	[JsonPropertyName( "install_params" )]
	public InstallParams InstallParams { get; set; } = null;

	/// <summary>
	/// The application's default custom authorization link, if enabled
	/// </summary>
	[JsonPropertyName( "custom_install_url" )]
	public string CustomInstallUrl { get; set; } = string.Empty;

	/// <summary>
	/// The application's role connection verification entry point, which when configured will render the app as a verification method in the guild role verification configuration
	/// </summary>
	[JsonPropertyName( "role_connections_verification_url" )]
	public string RoleConnectionsVerificationUrl { get; set; } = string.Empty;
}
