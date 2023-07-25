using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedProvider
{
	/// <summary>
	///	Name of provider
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	///	Url of provider
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; } = string.Empty;
}
