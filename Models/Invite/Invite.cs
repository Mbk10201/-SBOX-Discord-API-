using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Invite
{
	// https://discord.com/developers/docs/resources/invite#invite-object

	/// <summary>
	/// The invite code (unique ID)
	/// </summary>
	[JsonPropertyName( "code" )]
	public string Code { get; set; }

	/// <summary>
	/// The guild this invite is for
	/// </summary>
	[JsonPropertyName( "guild" )]
	public Guild Guild { get; set; } = null;

	/// <summary>
	/// The channel this invite is for
	/// </summary>
	[JsonPropertyName( "channel" )]
	public Channel Channel { get; set; } = null;

	/// <summary>
	///	The user who created the invite
	/// </summary>
	[JsonPropertyName( "inviter" )]
	public User Inviter { get; set; } = null;

	/// <summary>
	///	The type of target for this voice channel invite
	///	https://discord.com/developers/docs/resources/invite#invite-object-invite-target-types
	/// </summary>
	[JsonPropertyName( "target_type" )]
	public int? TargetType { get; set; }

	/// <summary>
	///	The user whose stream to display for this voice channel stream invite
	/// </summary>
	[JsonPropertyName( "target_user" )]
	public User TargetUser { get; set; } = null;

	/// <summary>
	///	The embedded application to open for this voice channel embedded application invite
	/// </summary>
	[JsonPropertyName( "target_application" )]
	public Application TargetApplication { get; set; } = null;

	/// <summary>
	///	Approximate count of online members, returned from the GET /invites/<code> endpoint when with_counts is true
	/// </summary>
	[JsonPropertyName( "approximate_presence_count" )]
	public int? ApproximatePresenceCount { get; set; }

	/// <summary>
	/// Approximate count of total members, returned from the GET /invites/<code> endpoint when with_counts is true
	/// </summary>
	[JsonPropertyName( "approximate_member_count" )]
	public int? ApproximateMemberCount { get; set; }

	/// <summary>
	/// The expiration date of this invite, returned from the GET /invites/<code> endpoint when with_expiration is true
	/// </summary>
	[JsonPropertyName( "expires_at" )]
	public object ExpiresAt { get; set; } = null;

	/// <summary>
	/// Stage instance data if there is a public Stage instance in the Stage channel this invite is for (deprecated)
	/// https://discord.com/developers/docs/resources/stage-instance
	/// </summary>
	[JsonPropertyName( "stage_instance" )]
	public InviteStageInstance StageInstance { get; set; } = null;

	/// <summary>
	/// Guild scheduled event data, only included if guild_scheduled_event_id contains a valid guild scheduled event id
	/// </summary>
	[JsonPropertyName( "guild_scheduled_event" )]
	public GuildScheduledEvent GuildScheduledEvent { get; set; } = null;
}
