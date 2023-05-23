using DiscordAPI.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class Overwrite
{
	/// <summary>
	///	Role or user id
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// Either 0 (role) or 1 (member)
	/// </summary>
	[JsonPropertyName( "type" )]
	public int Type { get; set; }

	/// <summary>
	/// Permission bit set
	/// </summary>
	[JsonPropertyName( "roles" )]
	public string Allow { get; set; }

	/// <summary>
	/// Permission bit set
	/// </summary>
	[JsonPropertyName( "deny" )]
	public string Deny { get; set; }
}
