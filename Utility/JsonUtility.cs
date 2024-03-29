﻿using System.Net.Http;
using System.Text.Json;

namespace Mbk.Discord.Utility;

internal static class JsonUtility
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

	public static async Task<T> ReadFromJson<T>( HttpResponseMessage response )
	{
		var json = await response.Content.ReadAsStreamAsync();
		return JsonSerializer.Deserialize<T>( json );
	}
}
