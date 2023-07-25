
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Activity
{
	/// <summary>
	/// 	Activity's name
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// Activity type
	/// https://discord.com/developers/docs/topics/gateway-events#activity-object-activity-types
	/// </summary>
	[JsonPropertyName( "type" )]
	public ActivityType Type { get; set; }

	/// <summary>
	/// Stream URL, is validated when type is 1
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; } = null;

	/// <summary>
	/// Unix timestamp (in milliseconds) of when the activity was added to the user's session
	/// </summary>
	[JsonPropertyName( "created_at" )]
	public int CreatedAt { get; set; }

	/// <summary>
	/// 	Unix timestamps for start and/or end of the game
	/// </summary>
	[JsonPropertyName( "timestamps" )]
	public List<ActivityTimestamp> Timestamps { get; set; } = null;

	/// <summary>
	/// Application ID for the game
	/// </summary>
	[JsonPropertyName( "application_id" )]
	public long? AppID { get; set; }

	/// <summary>
	/// What the player is currently doing
	/// </summary>
	[JsonPropertyName( "details" )]
	public string Details { get; set; } = null;

	/// <summary>
	/// User's current party status
	/// </summary>
	[JsonPropertyName( "state" )]
	public string State { get; set; } = null;

	/// <summary>
	/// User's current party status
	/// </summary>
	[JsonPropertyName( "emoji" )]
	public ActivityEmoji emoji { get; set; } = null;

	/// <summary>
	///	Information for the current party of the player
	/// </summary>
	[JsonPropertyName( "party" )]
	public ActivityParty Party { get; set; } = null;

	/// <summary>
	///	Images for the presence and their hover texts
	/// </summary>
	[JsonPropertyName( "assets" )]
	public ActivityAssets Assets { get; set; } = null;

	/// <summary>
	///	Secrets for Rich Presence joining and spectating
	/// </summary>
	[JsonPropertyName( "secrets" )]
	public ActivitySecrets Secrets { get; set; } = null;

	/// <summary>
	///	Whether or not the activity is an instanced game session
	/// </summary>
	[JsonPropertyName( "instance" )]
	public bool? Instance { get; set; }

	/// <summary>
	///	Activity flags ORd together, describes what the payload includes
	///	https://discord.com/developers/docs/topics/gateway-events#activity-object-activity-flags
	/// </summary>
	[JsonPropertyName( "flags" )]
	public ActivityFlags? Flags { get; set; }


	/// <summary>
	///		Custom buttons shown in the Rich Presence (max 2)
	/// </summary>
	[JsonPropertyName( "buttons" )]
	public List<ActivityButtons> buttons { get; set; } = null;
}
