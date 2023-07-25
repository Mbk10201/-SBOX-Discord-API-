using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class IdentifyStructure
{
	// According to the discord docs (https://discord.com/developers/docs/topics/gateway-events#payload-structure)

	/// <summary>
	/// Authentication token
	/// </summary>
	[JsonPropertyName( "token" )]
	public string Token => Client.Instance.Token;

	/// <summary>
	///	Gateway Intents you wish to receive
	/// </summary>
	[JsonPropertyName( "intents" )]
	public int Intents { get; set; } = 513;

	/// <summary>
	///	Gateway Intents you wish to receive
	/// </summary>
	[JsonPropertyName( "properties" )]
	public Properties Properties { get; set; } = new Properties()
	{
		OS = "linux",
		Browser = "my_library",
		Device = "my_library"
	};

	/// <summary>
	///	Whether this connection supports compression of packets
	///	Default: false
	/// </summary>
	[JsonPropertyName( "compress" )]
	public bool? Compress { get; set; }

	/// <summary>
	///	Value between 50 and 250, total number of members where the gateway will stop sending offline members in the guild member list
	///	Default: 50
	/// </summary>
	[JsonPropertyName( "large_threshold" )]
	public int? LargeThreshold { get; set; }

	/// <summary>
	///	Presence structure for initial presence information
	/// </summary>
	[JsonPropertyName( "presence" )]
	public Presence presence { get; set; } = new Presence()
	{
		Activities= new List<Activity>()
		{
			new()
			{
				Name = $"{Game.Server.GameTitle}: {Game.Clients.Count} / {Game.Server.MaxPlayers}",
				Type = ActivityType.GAME,
				Details = "Je baise ta mère"
			}
		},
		Status = "dnd",
		AFK = false
	};
}
