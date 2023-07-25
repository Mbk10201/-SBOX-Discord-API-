
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivityTimestamp
{
	/// <summary>
	/// Unix time (in milliseconds) of when the activity started
	/// </summary>
	[JsonPropertyName( "start" )]
	public int? Start { get; set; }

	/// <summary>
	/// Unix time (in milliseconds) of when the activity ends
	/// </summary>
	[JsonPropertyName( "end" )]
	public int? End { get; set; }
}
