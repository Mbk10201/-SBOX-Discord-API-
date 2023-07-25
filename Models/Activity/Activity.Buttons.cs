
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivityButtons
{
	/// <summary>
	/// Text shown on the button (1-32 characters)
	/// </summary>
	[JsonPropertyName( "label" )]
	public string Label { get; set; }

	/// <summary>
	///	URL opened when clicking the button (1-512 characters)
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; }
}
