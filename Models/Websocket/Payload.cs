using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Payload
{
	// According to the discord docs (https://discord.com/developers/docs/topics/gateway-events#payload-structure)

	/// <summary>
	/// Gateway opcode, which indicates the payload type
	/// Types (https://discord.com/developers/docs/topics/opcodes-and-status-codes#gateway-gateway-opcodes)
	/// </summary>
	[JsonPropertyName( "op" )]
	public int OPCode { get; set; }

	/// <summary>
	/// Event data as JSON format
	/// </summary>
	[JsonPropertyName( "d" )]
	public object Data { get; set; }

	/// <summary>
	/// Sequence number of event used for resuming sessions and heartbeating
	/// </summary>
	[JsonPropertyName( "s" )]
	public int? Sequence { get; set; }

	/// <summary>
	///	Event name
	/// </summary>
	[JsonPropertyName( "t" )]
	public string EventName { get; set; } = null;
}
