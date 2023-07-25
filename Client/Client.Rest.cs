using Discord.Models;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Discord;

public partial class Client
{
	public const string Discord_ApiPoint = "https://discord.com/api";
	public const string APIVersion = "v10";

	public static Dictionary<string, string> GetHeaders() => new()
	{
		{ "Content-Type", "application/json" },
		{ "Authorization", $"Bot {Instance.Token}" }
	};

	private static bool IsTokenValid()
	{
		if ( Instance.Token == string.Empty )
			return false;

		if (Instance.Token.Length > 72)
			return false;

		/*if ( IsRegexValid( Instance.Token ) )
			return false;*/ // TO FIX
			
		return true;
	}

	public static bool IsRegexValid(string token)
	{
		string pattern = @"[A-Za-z\d]{24}\.[A-Za-z\d-_]{6}\.[A-Za-z\d-_]{27}";

		Match match = Regex.Match( token, pattern );
		if ( !match.Success )
			return false;
		else
			return true;
	}

	public static Task<T> Get<T>( string destination )
	{
		var url = $"{Discord_ApiPoint}/{destination}";
		return Http.RequestJsonAsync<T>( url, "GET", headers: GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination, T payload, Dictionary<string, string> Headers )
	{
		var url = $"{Discord_ApiPoint}/{destination}";
		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", url, content, Headers );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination, T payload )
	{
		if ( Instance.Token == string.Empty )
			return null;

		var url = $"{Discord_ApiPoint}/{destination}";

		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", url, content, GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string destination )
	{
		if ( Instance.Token == string.Empty )
			return null;

		var url = $"{Discord_ApiPoint}/{destination}";

		return Http.RequestAsync( "POST", url, headers: GetHeaders() );
	}
}
