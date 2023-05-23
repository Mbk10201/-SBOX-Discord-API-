using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DiscordAPI.Models;
using Sandbox;

namespace DiscordAPI;

public static class API
{
	public const string Discord_ApiPoint = "https://discord.com/api";
	public const string APIVersion = "v10";

	public static Task<T> Get<T>( string uri )
	{
		return Http.RequestJsonAsync<T>( uri, "GET", headers: Bot.GetHeaders() );
	}

	public static bool IsTokenValid()
	{
		if ( Bot.Instance.Token == string.Empty )
			return false;
		
		var response = Http.RequestAsync( "GET", $"{Discord_ApiPoint}{APIVersion}/gateway", headers: Bot.GetHeaders() ).Result;

		return (response.StatusCode == System.Net.HttpStatusCode.OK);
	}

	public static Task<HttpResponseMessage> Post<T>( string uri, T payload, Dictionary<string, string> Headers)
	{
		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", uri, content, Headers );
	}

	public static Task<HttpResponseMessage> Post<T>( string uri, T payload )
	{
		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", uri, content, Bot.GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string uri )
	{
		return Http.RequestAsync( "POST", uri, headers: Bot.GetHeaders() );
	}

	public static async Task<T> ReadFromJson<T>( HttpResponseMessage response )
	{
		var json = await response.Content.ReadAsStreamAsync();
		return JsonSerializer.Deserialize<T>( json );
	}
}
