using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public partial class GameEventSettings : BaseNetworkable
{
	/// <summary>
	/// The event unique identifier
	/// </summary>
	[JsonPropertyName( "identifier" )]
	[Net] public string Identifier { get; set; }

	/// <summary>
	/// The event name for UI and discord title
	/// </summary>
	[JsonPropertyName( "name" )]
	[Net] public string Name { get; set; }

	/// <summary>
	/// The event description
	/// </summary>
	[JsonPropertyName( "description" )]
	[Net] public string Description { get; set; }

	/// <summary>
	/// Enable or disable the event broadcast on discord
	/// </summary>
	[JsonPropertyName( "broadcast" )]
	[Net] public bool Broadcast { get; set; } = true;

	/// <summary>
	/// Enable or disable embedded message
	/// True = Embed message
	/// False = Classic message
	/// </summary>
	[JsonPropertyName( "display_embed" )]
	[Net] public bool DisplayEmbed { get; set; } = true;

	/// <summary>
	/// HEX color of the embed ( WITHOUT THE '#' symbol because is a reserved symbol for sbox i18)
	/// </summary>
	[JsonPropertyName( "hexcolor_embed" )]
	[Net] public string HexColorEmbed { get; set; } = "ffffff";

	/// <summary>
	/// Switch between Bot or Webhook
	/// False = Webhook
	/// True = Bot
	/// </summary>
	[JsonPropertyName( "use_asbot" )]
	[Net] public bool UseAsBot { get; set; } = true;

	/// <summary>
	/// Discord channel id if the UseAsBot is true
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	[Net] public long? ChannelID { get; set; }

	/// <summary>
	/// The webhook url
	/// </summary>
	[JsonPropertyName( "webhook" )]
	[Net] public string Webhook { get; set; } = null;

	/// <summary>
	/// Return the current HexColorEmbed value as an INT for discord color pallet
	/// </summary>
	public int GetColor()
	{
		int value;

		if ( HexColorEmbed.Contains( "#" ) )
		{
			string[] split = HexColorEmbed.Split( "#" );
			value = int.Parse( split[1], System.Globalization.NumberStyles.HexNumber );
		}
		else
			value = int.Parse( HexColorEmbed, System.Globalization.NumberStyles.HexNumber );

		return value;
	}
}
