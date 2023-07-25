using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedAuthor
{
	/// <summary>
	///	Name of author
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	///	Url of author (only supports http(s))
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Url of author icon (only supports http(s) and attachments)
	/// </summary>
	[JsonPropertyName( "icon_url" )]
	public string IconUrl { get; set; } = string.Empty;

	/// <summary>
	/// A proxied url of author icon
	/// </summary>
	[JsonPropertyName( "proxy_icon_url" )]
	public string Width { get; set; } = string.Empty;
}
