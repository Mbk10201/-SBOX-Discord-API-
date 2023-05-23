using DiscordAPI.Models;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiscordAPI;

public class Settings
{
	public Settings()
	{

		if ( !FileSystem.OrganizationData.FileExists( "discord_settings.json" ) )
			Save( this );
		/*else
			Load();*/
	}

	/// <summary>
	/// If true, the message of game events will be sent as embeded.
	/// </summary>
	[JsonPropertyName( "is_defaultmessage_embed" )]
	public bool AsEmbed { get; set; } = true;

	public void Load()
	{
		var data = FileSystem.OrganizationData.ReadJson<Settings>( "discord_settings.json" );

		Log.Info( data );
		AsEmbed = data.AsEmbed;
		//PlayerJoinEvent = data.PlayerJoinEvent;
	}

	public static void Save(Settings settings)
	{
		FileSystem.OrganizationData.WriteJson( "discord_settings.json", settings );
	}
}
