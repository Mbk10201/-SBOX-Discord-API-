using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildMembersChunk
{
	/// <summary>
	/// The ID of the guild (server) for which the member chunk is being sent.
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// An array of member objects containing information about the guild members included in the chunk. 
	/// Each member object represents a user and includes details such as their ID, username, discriminator, avatar, member-related details, etc.
	/// </summary>
	[JsonPropertyName( "Members" )]
	public List<GuildMember> Members { get; set; } = null;

	/// <summary>
	/// The index of the member chunk in the sequence of chunks being sent.
	/// </summary>
	[JsonPropertyName( "chunk_index" )]
	public object ChunkIndex { get; set; } = null;

	/// <summary>
	/// The total number of chunks expected for this guild.
	/// </summary>
	[JsonPropertyName( "chunk_count" )]
	public object ChunkCount { get; set; } = null;

	/// <summary>
	/// An array of user IDs for which member data was requested but not found. This may happen if the requested members have left the guild or their data is no longer available.
	/// </summary>
	[JsonPropertyName( "not_found" )]
	public List<string> NotFound { get; set; } = null;

	/// <summary>
	/// An array of presence objects representing the presence (online status, activities, etc.) of the members included in the chunk. Each presence object provides 
	/// </summary>
	[JsonPropertyName( "presences" )]
	public List<Presence> Presences { get; set; } = null;

	/// <summary>
	/// A nonce value that was included in the original GUILD_MEMBER_CHUNK request. This field is optional and only present if a nonce was provided in the request.
	/// </summary>
	[JsonPropertyName( "nonce" )]
	public string Nonce { get; set; } = null;
}
