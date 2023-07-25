using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class MessageActivity
{
	/// <summary>
	/// Type of message activity
	/// </summary>
	[JsonPropertyName( "type" )]
	public MessageActivityTypes Type { get; set; }

	/// <summary>
	/// Party_id from a Rich Presence event
	/// </summary>
	[JsonPropertyName( "party_id" )]
	public long? PartyID { get; set; }
	
}
