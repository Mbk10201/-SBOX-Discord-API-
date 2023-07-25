using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ClientStatus
{
	/// <summary>
	/// The desktop (COMPUTER APP) status
	/// </summary>
	[JsonPropertyName( "desktop" )]
	public object Desktop { get; set; }

	/// <summary>
	/// The mobile status
	/// </summary>
	[JsonPropertyName( "mobile" )]
	public object Mobile { get; set; }

	/// <summary>
	/// The web (WEB APP) status
	/// </summary>
	[JsonPropertyName( "web" )]
	public object Web { get; set; }
}
