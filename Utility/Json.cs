using System.Text.Json;

namespace DiscordAPI.Utility;

internal static class Json
{
	public static string Serialize( this object obj )
	{
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			ReadCommentHandling = JsonCommentHandling.Skip,
			PropertyNameCaseInsensitive = true,
			AllowTrailingCommas = true,
			WriteIndented = true
		};

		return JsonSerializer.Serialize( obj, options );
	}

	public static T Deserialize<T>( this string str )
	{
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			ReadCommentHandling = JsonCommentHandling.Skip,
			PropertyNameCaseInsensitive = true,
			AllowTrailingCommas = true
		};

		return JsonSerializer.Deserialize<T>( str, options );
	}

}
