
using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ActivityAssets
{
	/// <summary>
	/// 	See Activity Asset Image
	/// https://discord.com/developers/docs/topics/gateway-events#activity-object-activity-asset-image
	/// </summary>
	[JsonPropertyName( "large_image" )]
	public string LargeImage { get; set; } = null;

	/// <summary>
	/// Text displayed when hovering over the large image of the activity
	/// </summary>
	[JsonPropertyName( "large_text" )]
	public string LargeText { get; set; } = null;

	/// <summary>
	///	See Activity Asset Image
	///	https://discord.com/developers/docs/topics/gateway-events#activity-object-activity-asset-image
	/// </summary>
	[JsonPropertyName( "small_image" )]
	public string SmallImage { get; set; } = null;

	/// <summary>
	/// Text displayed when hovering over the small image of the activity
	/// </summary>
	[JsonPropertyName( "small_text" )]
	public string SmallText { get; set; } = null;
}
