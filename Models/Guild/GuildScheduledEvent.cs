using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildScheduledEvent
{
	// https://discord.com/developers/docs/resources/guild-scheduled-event#guild-scheduled-event-object

	/// <summary>
	/// The id of the scheduled event
	/// </summary>
	[JsonPropertyName( "count" )]
	public object Id { get; set; }

	/// <summary>
	/// The guild id which the scheduled event belongs to
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; }

	/// <summary>
	/// The channel id in which the scheduled event will be hosted, or null if scheduled entity type is EXTERNAL
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; } = null;

	/// <summary>
	/// The id of the user that created the scheduled event *
	/// </summary>
	[JsonPropertyName( "creator_id" )]
	public object CreatorID { get; set; } = null;

	/// <summary>
	/// The name of the scheduled event (1-100 characters)
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// The description of the scheduled event (1-1000 characters)
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; } = null;

	/// <summary>
	/// The time the scheduled event will start
	/// </summary>
	[JsonPropertyName( "scheduled_start_time" )]
	public object ScheduledStartTime { get; set; }

	/// <summary>
	/// The time the scheduled event will end, required if entity_type is EXTERNAL
	/// </summary>
	[JsonPropertyName( "scheduled_end_time" )]
	public object ScheduledEndTime { get; set; }

	/// <summary>
	/// The privacy level of the scheduled event
	/// </summary>
	[JsonPropertyName( "privacy_level" )]
	public PrivacyLevelTypes PrivacyLevel { get; set; }

	/// <summary>
	/// The status of the scheduled event
	/// </summary>
	[JsonPropertyName( "status" )]
	public EventStatusTypes Status { get; set; }

	/// <summary>
	/// The type of the scheduled event
	/// </summary>
	[JsonPropertyName( "entity_type" )]
	public ScheduledEntityTypes EntityType { get; set; }

	/// <summary>
	/// The id of an entity associated with a guild scheduled event
	/// </summary>
	[JsonPropertyName( "entity_id" )]
	public object EntityID { get; set; } = null;

	/// <summary>
	///	Additional metadata for the guild scheduled event
	/// </summary>
	[JsonPropertyName( "entity_metadata" )]
	public ScheduledEventMeta EntityMetadata { get; set; } = null;

	/// <summary>
	///	The user that created the scheduled event
	/// </summary>
	[JsonPropertyName( "creator" )]
	public User Creator { get; set; } = null;

	/// <summary>
	///	The number of users subscribed to the scheduled event
	/// </summary>
	[JsonPropertyName( "user_count" )]
	public int? UserCount { get; set; }

	/// <summary>
	///	The cover image hash of the scheduled event
	/// </summary>
	[JsonPropertyName( "image" )]
	public string Image { get; set; } = null;
}

