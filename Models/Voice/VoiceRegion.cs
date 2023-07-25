using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class VoiceRegion
{
	/// <summary>
	/// Unique ID for the region
	/// </summary>
	[JsonPropertyName( "id" )]
	public int Id { get; set; }

	/// <summary>
	/// Name of the region
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// True for a single server that is closest to the current user's client
	/// </summary>
	[JsonPropertyName( "optimal" )]
	public bool Optimal { get; set; }

	/// <summary>
	/// Whether this is a deprecated voice region (avoid switching to these)
	/// </summary>
	[JsonPropertyName( "deprecated" )]
	public bool Deprecated { get; set; }

	/// <summary>
	/// Whether this is a custom voice region (used for events/etc)
	/// </summary>
	[JsonPropertyName( "custom" )]
	public bool Custom { get; set; }
}
