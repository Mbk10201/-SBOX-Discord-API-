using DiscordAPI.Enums;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class EventSettings
{
	/// <summary>
	/// The event unique identifier
	/// </summary>
	[JsonPropertyName( "identifier" )]
	public string Identifier { get; set; }

	/// <summary>
	/// The event name for UI & Discord
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// The event description
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; }

	/// <summary>
	/// The event category
	/// </summary>
	[JsonPropertyName( "category" )]
	public string Category { get; set; }

	/// <summary>
	/// Enable or disable the event broadcast on discord
	/// </summary>
	[JsonPropertyName( "broadcast" )]
	public bool Broadcast { get; set; } = true;

	/// <summary>
	/// Enable or disable embedded message
	/// True = Embed message
	/// False = Classic message
	/// </summary>
	[JsonPropertyName( "display_embed" )]
	public bool DisplayEmbed { get; set; } = true;

	/// <summary>
	/// HEX color of the embed
	/// </summary>
	[JsonPropertyName( "hexcolor_embed" )]
	public string HexColorEmbed { get; set; } = "#ffffff";

	/// <summary>
	/// Switch between Bot or Webhook
	/// False = Webhook
	/// True = Bot
	/// </summary>
	[JsonPropertyName( "use_asbot" )]
	public bool UseAsBot { get; set; } = true;

	/// <summary>
	/// Discord channel id if the UseAsBot is true
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public long? ChannelID { get; set; }

	/// <summary>
	/// The webhook url
	/// </summary>
	[JsonPropertyName( "webhook" )]
	public string Webhook { get; set; } = null;

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
