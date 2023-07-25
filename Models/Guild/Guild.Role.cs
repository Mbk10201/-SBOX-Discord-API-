using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildRole
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
	[JsonPropertyName( "user" )]
	public Role User { get; set; } = null;
}
