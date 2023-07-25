using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Stage
{
	// https://discord.com/developers/docs/resources/stage-instance#stage-instance-object

	/// <summary>
	/// The id of this Stage instance
	/// </summary>
	[JsonPropertyName( "count" )]
	public object Id { get; set; }

	/// <summary>
	/// The guild id of the associated Stage channel
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; }

	/// <summary>
	/// The id of the associated Stage channel
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; }

	/// <summary>
	/// The topic of the Stage instance (1-120 characters)
	/// </summary>
	[JsonPropertyName( "topic" )]
	public string Topic { get; set; }

	/// <summary>
	/// The privacy level of the Stage instance
	/// (https://discord.com/developers/docs/resources/stage-instance#stage-instance-object-privacy-level)
	/// </summary>
	[JsonPropertyName( "privacy_level" )]
	public int PrivacyLevel { get; set; }

	/// <summary>
	/// Whether or not Stage Discovery is disabled (deprecated)
	/// (https://discord.com/developers/docs/resources/stage-instance#stage-instance-object-privacy-level)
	/// </summary>
	[JsonPropertyName( "discoverable_disabled" )]
	public bool DiscoverableDisabled { get; set; }

	/// <summary>
	/// 	The id of the scheduled event for this Stage instance
	/// </summary>
	[JsonPropertyName( "guild_scheduled_event_id" )]
	public object GuildScheduledEventID { get; set; } = null;
}
