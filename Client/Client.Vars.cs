using Discord.Models;

namespace Discord;

public partial class Client
{
	[Net] public Guild Guild { get; set; }
}
