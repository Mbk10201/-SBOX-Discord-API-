using Mbk.Discord.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class TeamMember
{
	/// <summary>
	///	The user's membership state on the team
	/// </summary>
	[JsonPropertyName( "membership_state" )]
	public MembershipState MembershipState { get; set; }

	/// <summary>
	///	Will always be ["*"]
	/// </summary>
	[JsonPropertyName( "permissions" )]
	public List<string> Permissions { get; set; }

	/// <summary>
	/// The id of the parent team of which they are a member
	/// </summary>
	[JsonPropertyName( "team_id" )]
	public long TeamID { get; set; }

	/// <summary>
	/// The avatar, discriminator, id, and username of the user
	/// </summary>
	[JsonPropertyName( "user" )]
	public User User { get; set; }

	public TeamMember()
	{
		Permissions = new();
	}
}
