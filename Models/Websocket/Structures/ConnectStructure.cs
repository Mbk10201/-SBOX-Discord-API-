using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class ConnectStructure
{
	/// <summary>
	/// The heartbeat interval given in milliseconds
	/// </summary>
	[JsonPropertyName( "heartbeat_interval" )]
	public int Heartbeat_Interval { get; set; }
}
