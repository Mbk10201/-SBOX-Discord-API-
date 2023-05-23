using DiscordAPI.Enums;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class EventSettings
{
	/// <summary>
	/// The event unique identifier
	/// </summary>
	[JsonPropertyName( "identifier" )]
	public string Identifier { get; set; }

	/// <summary>
	/// The event name for UI & Discord
	/// </summary>
	[JsonPropertyName( "identifier" )]
	public string Name { get; set; }

	/// <summary>
	/// The event description
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; }

	/// <summary>
	/// The event category
	/// </summary>
	[JsonPropertyName( "category" )]
	public string Category { get; set; }

	/// <summary>
	/// Enable or disable the event broadcast on discord
	/// </summary>
	[JsonPropertyName( "broadcast" )]
	public bool Broadcast { get; set; } = true;
}
