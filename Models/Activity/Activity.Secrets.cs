
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivitySecrets
{
	/// <summary>
	/// Secret for joining a party
	/// </summary>
	[JsonPropertyName( "join" )]
	public string Join { get; set; } = null;

	/// <summary>
	/// Secret for spectating a game
	/// </summary>
	[JsonPropertyName( "spectateG" )]
	public string Spectate { get; set; } = null;

	/// <summary>
	///	Secret for a specific instanced match
	/// </summary>
	[JsonPropertyName( "match" )]
	public string Match { get; set; } = null;
}
