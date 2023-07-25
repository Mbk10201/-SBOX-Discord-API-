using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ScheduledEventMeta
{
	// https://discord.com/developers/docs/resources/guild-scheduled-event#guild-scheduled-event-object-guild-scheduled-event-entity-metadata

	/// <summary>
	/// Location of the event (1-100 characters)
	/// </summary>
	[JsonPropertyName( "count" )]
	public string location { get; set; } = null;
}
