using Sandbox;
using System.Text.Json.Serialization;

namespace Discord.Models;

public class ThreadMember
{
	/// <summary>
	/// ID of the thread
	/// </summary>
	[JsonPropertyName( "id" )]
	public long? Id { get; set; }

	/// <summary>
	/// ID of the user
	/// </summary>
	[JsonPropertyName( "user_id" )]
	public long? UserID { get; set; }

	/// <summary>
	/// Time the user last joined the thread
	/// </summary>
	[JsonPropertyName( "join_timestamp" )]
	public RealTimeSince JoinTimestamp { get; set; }

	/// <summary>
	/// Any user-thread settings, currently only used for notifications
	/// </summary>
	[JsonPropertyName( "flags" )]
	public int Flags { get; set; }

	/// <summary>
	/// Additional information about the user
	/// </summary>
	[JsonPropertyName( "member" )]
	public GuildMember Member { get; set; }
}
