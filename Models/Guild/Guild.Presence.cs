using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildPresence
{
	/// <summary>
	/// The guild id where the presence was updated
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The user which the presence was updated
	/// </summary>
	[JsonPropertyName( "user" )]
	public User User { get; set; } = null;

	/// <summary>
	/// The new user status
	/// </summary>
	[JsonPropertyName( "status" )]
	public object Status { get; set; } = null;

	/// <summary>
	/// The user activity list
	/// </summary>
	[JsonPropertyName( "activities" )]
	public List<Activity> Activities { get; set; } = null;

	/// <summary>
	/// The user status on differents devices
	/// </summary>
	[JsonPropertyName( "client_status" )]
	public ClientStatus ClientStatus { get; set; } = null;
}
