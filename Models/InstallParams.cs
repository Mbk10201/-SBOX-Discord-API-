using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class InstallParams
{
	/// <summary>
	/// The scopes to add the application to the server with
	/// </summary>
	[JsonPropertyName( "scopes" )]
	public List<string> Scopes { get; set; }

	/// <summary>
	/// The permissions to request for the bot role
	/// </summary>
	[JsonPropertyName( "permissions" )]
	public string Permissions { get; set; }
}
