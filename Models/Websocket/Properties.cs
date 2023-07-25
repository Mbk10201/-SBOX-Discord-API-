using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Properties
{
	// According to the discord docs (https://discord.com/developers/docs/topics/gateway-events#payload-structure)

	[JsonPropertyName( "os" )]
	public string OS { get; set; }

	[JsonPropertyName( "browser" )]
	public string Browser { get; set; }

	[JsonPropertyName( "device" )]
	public string Device { get; set; }

	[JsonPropertyName( "referrer" )]
	public string Referrer { get; set; } = null;

	[JsonPropertyName( "referring_domain" )]
	public string ReferringDomain { get; set; } = null;
}
