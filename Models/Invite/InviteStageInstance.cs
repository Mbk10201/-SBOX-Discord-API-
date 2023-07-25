using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class InviteStageInstance
{
	// https://discord.com/developers/docs/resources/invite#invite-stage-instance-object

	/// <summary>
	/// The members speaking in the Stage
	/// </summary>
	[JsonPropertyName( "members" )]
	public List<GuildMember> Members { get; set; }

	/// <summary>
	/// The number of users in the Stage
	/// </summary>
	[JsonPropertyName( "participant_count" )]
	public int ParticipantCount { get; set; }

	/// <summary>
	/// The number of users speaking in the Stage
	/// </summary>
	[JsonPropertyName( "speaker_count" )]
	public int SpeakerCount { get; set; }

	/// <summary>
	/// The topic of the Stage instance (1-120 characters)
	/// </summary>
	[JsonPropertyName( "topic" )]
	public string Topic { get; set; }
}
