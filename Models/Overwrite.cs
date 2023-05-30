using System.Text.Json.Serialization;

namespace Discord.Models;

public partial class Overwrite : BaseNetworkable
{
	// https://discord.com/developers/docs/resources/channel#overwrite-object

	/// <summary>
	///	Role or user id
	/// </summary>
	[JsonPropertyName( "id" )]
	[Net] public string Id { get; set; }

	/// <summary>
	/// Either 0 (role) or 1 (member)
	/// </summary>
	[JsonPropertyName( "type" )]
	[Net] public string Type { get; set; }

	/// <summary>
	/// Permission bit set
	/// </summary>
	[JsonPropertyName( "roles" )]
	[Net] public string Allow { get; set; }

	/// <summary>
	/// Permission bit set
	/// </summary>
	[JsonPropertyName( "deny" )]
	[Net] public ulong Deny { get; set; }
}
