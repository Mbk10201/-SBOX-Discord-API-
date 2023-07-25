using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildEmojiUpdate
{
	//?

	/// <summary>
	/// The guild id
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The guild role
	/// </summary>
	[JsonPropertyName( "emojis" )]
	public List<Emoji> Emojis { get; set; } = null;
}
