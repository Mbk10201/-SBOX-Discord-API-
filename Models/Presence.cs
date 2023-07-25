using Mbk.Discord.Enums;
using Sandbox;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Presence
{
	/// <summary>
	/// Unix time (in milliseconds) of when the client went idle, or null if the client is not idle
	/// </summary>
	[JsonPropertyName( "Since" )]
	public int Since { get; set; } = 0;

	/// <summary>
	/// User's activities
	/// </summary>
	[JsonPropertyName( "activities" )]
	public List<Activity> Activities { get; set; }

	/// <summary>
	/// User's new status
	/// https://discord.com/developers/docs/topics/gateway-events#update-presence-status-types
	/// </summary>
	[JsonPropertyName( "status" )]
	public string Status { get; set; }

	/// <summary>
	/// Whether or not the client is afk
	/// </summary>
	[JsonPropertyName( "afk" )]
	public bool AFK { get; set; }
}
