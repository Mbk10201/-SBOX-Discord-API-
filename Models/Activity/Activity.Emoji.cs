
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivityEmoji
{
	/// <summary>
	/// Name of the emoji
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// 	ID of the emoji
	/// </summary>
	[JsonPropertyName( "id" )]
	public long? Id { get; set; }

	/// <summary>
	/// Whether the emoji is animated
	/// </summary>
	[JsonPropertyName( "animated" )]
	public bool? animated { get; set; }
}
