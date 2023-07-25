using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedImage
{
	/// <summary>
	///	Source url of image (only supports http(s) and attachments)
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; }

	/// <summary>
	///	A proxied url of the image
	/// </summary>
	[JsonPropertyName( "proxy_url" )]
	public string ProxyUrl { get; set; } = string.Empty;

	/// <summary>
	/// Height of image
	/// </summary>
	[JsonPropertyName( "height" )]
	public int? Height { get; set; }

	/// <summary>
	/// Width of image
	/// </summary>
	[JsonPropertyName( "width" )]
	public int? Width { get; set; }
}
