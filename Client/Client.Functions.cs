using Mbk.Discord.Enums;
using Mbk.Discord.Models;
using Mbk.Discord.Utility;

namespace Mbk.Discord;

public partial class Client
{
	public static async Task UpdatePresence(Presence presence)
	{
		if ( !WebSocket.IsConnected && !IsClientLogged() )
			return;

		var payload = new Payload
		{
			OPCode = (int)OPCodeTypes.STATUS_UPDATE,
			Data = presence
		};

		await WebSocket.Send( JsonUtility.Serialize( payload ) );
	}

	public static async Task<List<Message>> GetMessages( long channelid )
	{
		string destination = $"channels/{channelid}/messages";

		return await Get<List<Message>>( destination );
	}

	public static async Task<Message> GetMessage( long channelid, long messageid )
	{
		string destination = $"channels/{channelid}/messages/{messageid}";

		return await Get<Message>( destination );
	}
}
