using Mbk.Discord.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class GuildWebhookUpdate
{
	/// <summary>
	/// The guild id where the webhook has been updated
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The channel ID of the webhook parent
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; } = null;
}
