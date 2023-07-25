using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Team
{
	/// <summary>
	///	A hash of the image of the team's icon
	/// </summary>
	[JsonPropertyName( "icon" )]
	public string Icon { get; set; } = string.Empty;

	/// <summary>
	///	the unique id of the team
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	///	The members of the team
	/// </summary>
	[JsonPropertyName( "members" )]
	public List<TeamMember> Members { get; set; }

	/// <summary>
	///	The name of the team
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	///	The user id of the current team owner
	/// </summary>
	[JsonPropertyName( "owner_user_id" )]
	public long OwnerUserID { get; set; }

	public Team()
	{
		Members = new();
	}
}
