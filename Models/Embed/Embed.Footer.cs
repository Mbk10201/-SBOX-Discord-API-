using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedFooter
{
	/// <summary>
	///	Footer text
	/// </summary>
	[JsonPropertyName( "text" )]
	public string Title { get; set; }

	/// <summary>
	///	Url of footer icon (only supports http(s) and attachments)
	/// </summary>
	[JsonPropertyName( "icon_url" )]
	public string IconUrl { get; set; } = string.Empty;

	/// <summary>
	/// A proxied url of footer icon
	/// </summary>
	[JsonPropertyName( "proxy_icon_url" )]
	public string ProxyIconUrl { get; set; } = string.Empty;
}
