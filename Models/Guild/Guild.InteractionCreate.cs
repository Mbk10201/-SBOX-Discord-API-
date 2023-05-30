using Discord.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord.Models;

public class GuildInteractionCreate
{
	/// <summary>
	/// The ID of the guild (server) where the interaction occurred.
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The ID of the interaction.
	/// </summary>
	[JsonPropertyName( "id" )]
	public object Id { get; set; } = null;

	/// <summary>
	/// The type of interaction, which can be one of the following: 1 (Ping), 2 (Application Command), or 3 (Message Component).
	/// </summary>
	[JsonPropertyName( "type" )]
	public InteractionType? Type { get; set; }

	/// <summary>
	///  Additional data associated with the interaction. The structure of the data field depends on the interaction type. 
	///  For example, for application commands, it contains information about the invoked command.
	/// </summary>
	[JsonPropertyName( "data" )]
	public object Data { get; set; } = null;

	/// <summary>
	/// The ID of the channel where the interaction occurred.
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public object ChannelID { get; set; } = null;

	/// <summary>
	/// Information about the member (user) who initiated the interaction, including roles, nickname, and other member-related details. This field provides more detailed 
	/// </summary>
	[JsonPropertyName( "member" )]
	public GuildMember Member { get; set; } = null;

	/// <summary>
	/// The token associated with the interaction, which is used for responding to the interaction.
	/// </summary>
	[JsonPropertyName( "token" )]
	public string Token { get; set; } = null;

	/// <summary>
	/// The version of the interaction structure.
	/// </summary>
	[JsonPropertyName( "version" )]
	public object Version { get; set; } = null;
}
