using DiscordAPI.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiscordAPI.Models;

public class Channel
{
	/// <summary>
	/// The id of this channel
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// The type of channel
	/// </summary>
	[JsonPropertyName( "type" )]
	public ChannelTypes Type { get; set; }

	/// <summary>
	/// The id of the guild (may be missing for some channel objects received over gateway guild dispatches)
	/// </summary>
	[JsonPropertyName("guild_id")]
    public long? GuildID { get; set; }

	/// <summary>
	/// Sorting position of the channel
	/// </summary>
	[JsonPropertyName( "position" )]
	public int? Position { get; set; }

	/// <summary>
	/// Explicit permission overwrites for members and roles
	/// </summary>
	[JsonPropertyName( "permission_overwrites" )]
	public List<Overwrite> PermissionOverwrites { get; set; }

	/// <summary>
	/// The name of the channel (1-100 characters)
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The channel topic (0-4096 characters for GUILD_FORUM channels, 0-1024 characters for all others)
	/// </summary>
	[JsonPropertyName( "topic" )]
	public string Topic { get; set; } = string.Empty;

	/// <summary>
	/// Whether the channel is nsfw
	/// </summary>
	[JsonPropertyName( "nsfw" )]
	public bool? IsNsfw { get; set; }

	/// <summary>
	/// The id of the last message sent in this channel (or thread for GUILD_FORUM channels) (may not point to an existing or valid message or thread)
	/// </summary>
	[JsonPropertyName( "last_message_id" )]
	public long? LastMessageID { get; set; }

	/// <summary>
	/// The bitrate (in bits) of the voice channel
	/// </summary>
	[JsonPropertyName("bitrate")]
    public int BitRate { get; set; }

	/// <summary>
	///	The user limit of the voice channel
	/// </summary>
	[JsonPropertyName( "user_limit" )]
    public int UserLimit { get; set; }

	/// <summary>
	/// Amount of seconds a user has to wait before sending another message (0-21600); bots, as well as users with the permission manage_messages or manage_channel, are unaffected
	/// </summary>
	[JsonPropertyName( "rate_limit_per_user" )]
    public int RateLimitPerUser { get; set; }

	/// <summary>
	/// The recipients of the DM
	/// </summary>
	[JsonPropertyName( "recipients" )]
	public List<User> Recipients { get; set; } = null;

	/// <summary>
	/// Icon hash of the group DM
	/// </summary>
	[JsonPropertyName( "icon" )]
	public string Icon { get; set; } = string.Empty;

	/// <summary>
	/// Id of the creator of the group DM or thread
	/// </summary>
	[JsonPropertyName("owner_id")]
    public long? Owner { get; set; }

	/// <summary>
	/// 	application id of the group DM creator if it is bot-created
	/// </summary>
	[JsonPropertyName( "application_id" )]
	public long? ApplicationID { get; set; }

	/// <summary>
	/// For group DM channels: whether the channel is managed by an application via the gdm.join OAuth2 scope
	/// </summary>
	[JsonPropertyName( "managed" )]
	public bool? Managed { get; set; }

	/// <summary>
	/// For guild channels: id of the parent category for a channel (each parent category can contain up to 50 channels), for threads: id of the text channel this thread was created
	/// </summary>
	[JsonPropertyName("parent_id")]
    public long? ParentID { get; set; }

	/// <summary>
	/// When the last pinned message was pinned. This may be null in events such as GUILD_CREATE when a message is not pinned.
	/// </summary>
	[JsonPropertyName( "last_pin_timestamp" )]
	public RealTimeSince LastPin { get; set; }

	/// <summary>
	/// Voice region id for the voice channel, automatic when set to null
	/// </summary>
	[JsonPropertyName( "rtc_region" )]
	public string RtcRegion { get; set; } = string.Empty;

	/// <summary>
	/// The camera video quality mode of the voice channel, 1 when not present
	/// </summary>
	[JsonPropertyName( "video_quality_mode" )]
	public int? VideoQualityMode { get; set; }

	/// <summary>
	/// Number of messages (not including the initial message or deleted messages) in a thread.
	/// </summary>
	[JsonPropertyName( "message_count" )]
	public int? MessageCount { get; set; }

	/// <summary>
	/// An approximate count of users in a thread, stops counting at 50
	/// </summary>
	[JsonPropertyName( "member_count" )]
	public int? MemberCount { get; set; }

	/// <summary>
	/// Thread-specific fields not needed by other channels
	/// </summary>
	[JsonPropertyName( "thread_metadata" )]
	public ThreadMetadata ThreadMetadata { get; set; } = null;

	/// <summary>
	/// Thread member object for the current user, if they have joined the thread, only included on certain API endpoints
	/// </summary>
	[JsonPropertyName( "member" )]
	public ThreadMetadata Member { get; set; } = null;

	/// <summary>
	/// Default duration, copied onto newly created threads, in minutes, threads will stop showing in the channel list after the specified period of inactivity, can be set to: 60, 1440, 4320, 10080
	/// </summary>
	[JsonPropertyName( "default_auto_archive_duration" )]
	public int? DefAutoArchiveDuration { get; set; }

	/// <summary>
	/// Computed permissions for the invoking user in the channel, including overwrites, only included when part of the resolved dat
	/// </summary>
	[JsonPropertyName( "default_auto_archive_duration" )]
	public string Permissions { get; set; } = string.Empty;

	/// <summary>
	/// Channel flags combined as a bitfield
	/// </summary>
	[JsonPropertyName( "default_auto_archive_duration" )]
	public ChannelFlags? Flags { get; set; }

	/// <summary>
	/// Number of messages ever sent in a thread, it's similar to message_count on message creation, but will not decrement the number when a message is deleted
	/// </summary>
	[JsonPropertyName( "total_message_sent" )]
	public int? TotalMessages { get; set; }

	/// <summary>
	/// The set of tags that can be used in a GUILD_FORUM channel
	/// </summary>
	[JsonPropertyName( "available_tags" )]
	public List<ForumTag> AvailableTags { get; set; } = null;

	/// <summary>
	/// The IDs of the set of tags that have been applied to a thread in a GUILD_FORUM channel
	/// </summary>
	[JsonPropertyName( "applied_tags" )]
	public List<long> AppliedTags { get; set; } = null;

	/// <summary>
	/// The emoji to show in the add reaction button on a thread in a GUILD_FORUM channel
	/// </summary>
	[JsonPropertyName( "default_reaction_emoji" )]
	public DefaultReaction DefaultReaction { get; set; } = null;

	/// <summary>
	/// The initial rate_limit_per_user to set on newly created threads in a channel. this field is copied to the thread at creation time and does not live update.
	/// </summary>
	[JsonPropertyName( "default_thread_rate_limit_per_user" )] 
	public int? DefaultThreadRatePerUser { get; set; }

	/// <summary>
	/// The default sort order type used to order posts in GUILD_FORUM channels. Defaults to null, which indicates a preferred sort order hasn't been set by a channel admin
	/// </summary>
	[JsonPropertyName( "default_sort_order" )]
	public int? DefaultSortOrder { get; set; }

	/// <summary>
	/// The default forum layout view used to display posts in GUILD_FORUM channels. Defaults to 0, which indicates a layout view has not been set by a channel admin
	/// </summary>
	[JsonPropertyName( "default_forum_layout" )]
	public int? DefaultForumLayout { get; set; }	
	
	public async Task SendMessage(string message)
	{
		await GameTask.DelaySeconds( 1 );


	}

	public static async Task<List<Message>> GetMessages( long channelid )
	{
		string destination = $"channels/{channelid}/messages";

		return await Bot.Get<List<Message>>( destination );
	}

	public static async Task<Message> GetMessage( long channelid, long messageid )
	{
		string destination = $"channels/{channelid}/messages/{messageid}";

		return await Bot.Get<Message>( destination );
	}
}
