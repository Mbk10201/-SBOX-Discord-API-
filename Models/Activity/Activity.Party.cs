
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivityParty
{
	/// <summary>
	/// ID of the party
	/// </summary>
	[JsonPropertyName( "id" )]
	public string Id { get; set; } = null;

	/// <summary>
	/// Used to show the party's current and maximum size
	/// </summary>
	[JsonPropertyName( "size" )]
	public List<int> size { get; set; } = null;
}
