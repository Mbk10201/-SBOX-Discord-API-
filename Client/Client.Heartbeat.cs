using Mbk.Discord.Enums;
using Mbk.Discord.Models;
using Mbk.Discord.Utility;

namespace Mbk.Discord;

public partial class Client
{
	private static float HeartbeatInterval { get; set; }
	private static TimeSince Heartbeat { get; set; }

	[GameEvent.Tick]
	public static void Tick()
	{
		if(Game.IsServer && IsClientLogged() )
		{
			if ( Heartbeat >= HeartbeatInterval )
			{
				Heartbeat = 0;
				_ = SendHeartbeat();
			}
		}
	}

	static async Task SendHeartbeat()
	{
		var payload = new Payload
		{
			OPCode = (int)OPCodeTypes.HEARTBEAT,
			Data = 251
		};

		await WebSocket.Send( JsonUtility.Serialize( payload ) );
	}
}
