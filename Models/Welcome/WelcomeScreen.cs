using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class WelcomeScreen
{
	// https://discord.com/developers/docs/resources/guild#welcome-screen-object

	/// <summary>
	/// The server description shown in the welcome screen
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The channels shown in the welcome screen, up to 5
	/// </summary>
	[JsonPropertyName( "welcome_channels" )]
	public List<WelcomeScreenChannel> WelcomeChannels { get; set; }
}
