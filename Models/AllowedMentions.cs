using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class AllowedMentions
{
	/// <summary>
	///	An array of allowed mention types to parse from the content.
	///		"roles" -> Controls role mentions
	///		"users" -> Controls user mentions
	///		"everyone" -> Controls @everyone and @here mentions
	/// </summary>
	[JsonPropertyName( "parse" )]
	public List<string> Parse { get; set; } = null;

	/// <summary>
	///	Array of role_ids to mention (Max size of 100)
	/// </summary>
	[JsonPropertyName( "roles" )]
	public List<long> Roles { get; set; } = null;

	/// <summary>
	/// Array of user_ids to mention (Max size of 100)
	/// </summary>
	[JsonPropertyName( "users" )]
	public List<long> Users { get; set; } = null;

	/// <summary>
	/// For replies, whether to mention the author of the message being replied to (default false)
	/// </summary>
	[JsonPropertyName( "replied_user" )]
	public bool? RepliedUser { get; set; } = false;
}
