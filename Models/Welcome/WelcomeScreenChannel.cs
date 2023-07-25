using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class WelcomeScreenChannel
{
	// https://discord.com/developers/docs/resources/guild#welcome-screen-object-welcome-screen-channel-structure

	/// <summary>
	///	The channel's id
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; } = null;

	/// <summary>
	/// The description shown for the channel
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	///	The emoji id, if the emoji is custom
	/// </summary>
	[JsonPropertyName( "emoji_id" )]
	public object EmojiID { get; set; } = null;

	/// <summary>
	///	The emoji name if custom, the unicode character if standard, or null if no emoji is set
	/// </summary>
	[JsonPropertyName( "emoji_name" )]
	public object EmojiName { get; set; } = null;
}
