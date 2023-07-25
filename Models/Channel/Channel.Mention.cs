using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ChannelMention
{
	/// <summary>
	/// Id of the channel
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// Id of the guild containing the channel
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public long GuildID { get; set; }

	/// <summary>
	/// The type of channel
	/// </summary>
	[JsonPropertyName( "type" )]
	public ChannelTypes Type { get; set; }

	/// <summary>
	/// The name of the channel
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }
}
