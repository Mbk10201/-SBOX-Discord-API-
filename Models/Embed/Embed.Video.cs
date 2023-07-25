using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedVideo
{
	/// <summary>
	///	Source url of video
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	///	A proxied url of the video
	/// </summary>
	[JsonPropertyName( "proxy_url" )]
	public string ProxyUrl { get; set; } = string.Empty;

	/// <summary>
	/// Height of video
	/// </summary>
	[JsonPropertyName( "height" )]
	public int? Height { get; set; }

	/// <summary>
	/// Width of video
	/// </summary>
	[JsonPropertyName( "width" )]
	public int? Width { get; set; }
}
