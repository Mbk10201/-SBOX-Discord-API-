using Discord.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord.Models;

public class GuildVoiceServerUpdate
{
	/// <summary>
	/// The ID of the guild (server) where the voice server update occurred.
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	/// The authentication token required to connect to the voice server.
	/// </summary>
	[JsonPropertyName( "token" )]
	public object Token { get; set; } = null;

	/// <summary>
	/// The endpoint (URL) of the voice server that should be used for establishing a voice connection.
	/// </summary>
	[JsonPropertyName( "endpoint" )]
	public object EndPoint { get; set; } = null;
}
