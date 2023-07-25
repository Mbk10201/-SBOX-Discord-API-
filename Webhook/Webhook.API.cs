using System.Net.Http;

namespace Mbk.Discord;

public static partial class Webhook
{
	public const string Discord_ApiPoint = "https://discord.com/api";
	public const string APIVersion = "v10";

	public static Dictionary<string, string> GetHeaders() => new()
	{
		{ "Content-Type", "application/json" }
	};

	public static Task<T> Get<T>( string uri )
	{
		return Http.RequestJsonAsync<T>( uri, "GET", headers: GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string uri, T payload, Dictionary<string, string> Headers )
	{
		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", uri, content, Headers );
	}

	public static Task<HttpResponseMessage> Post<T>( string uri, T payload )
	{
		if ( uri == string.Empty )
			return null;

		var content = Http.CreateJsonContent( payload );
		return Http.RequestAsync( "POST", uri, content, GetHeaders() );
	}

	public static Task<HttpResponseMessage> Post<T>( string uri )
	{
		if ( uri == string.Empty )
			return null;

		return Http.RequestAsync( "POST", uri, headers: GetHeaders() );
	}
}
