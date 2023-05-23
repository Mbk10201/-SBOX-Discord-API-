using System.Collections.Generic;

namespace DiscordAPI;

public partial class Webhook
{
	public Dictionary<string, string> Urls { get; set; }

	public Webhook()
	{
		Urls = new();
	}
}
