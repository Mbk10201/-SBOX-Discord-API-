using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordAPI;

public static partial class Bot
{
	public const string Discord_ApiPoint = "https://discord.com/api";
	public const string APIVersion = "v10";

	public static Dictionary<string, string> GetHeaders() => new()
	{
		{ "Content-Type", "application/json" },
		{ "Authorization", $"Bot {Token}" }
	};

	public static bool IsTokenValid()
	{
		if ( Token == string.Empty )
			return false;

		var response = Http.RequestAsync( "GET", $"{Discord_ApiPoint}{APIVersion}/gateway", headers: GetHeaders() ).Result;

		return (response.StatusCode == System.Net.HttpStatusCode.OK);
	}

	public static Task<T> Get<T>( string destination )
	{
		var url = $"{Discord_ApiPoint}{destination}";
		return Http.RequestJsonAsync<T>( url, "GET", headers: GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination, T payload, Dictionary<string, string> Headers )
	{
		var url = $"{Discord_ApiPoint}{destination}";
		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", url, content, Headers );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination, T payload )
	{
		if ( Token == string.Empty )
			return null;

		var url = $"{Discord_ApiPoint}{destination}";

		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", url, content, GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination )
	{
		if ( Token == string.Empty )
			return null;

		var url = $"{Discord_ApiPoint}{destination}";

		return Http.RequestAsync( "POST", url, headers: GetHeaders() );
	}
}
