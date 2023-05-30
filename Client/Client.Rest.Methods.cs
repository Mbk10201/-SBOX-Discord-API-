using Discord.Models;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Discord;

public partial class Client
{
	public static async Task<List<Message>> GetChannelMessages( long channelid ) => await GetMessages( channelid );
	public static async Task<Message> GetChannelMessage( long channelid, long messageid ) => await GetMessage( channelid, messageid );
}
