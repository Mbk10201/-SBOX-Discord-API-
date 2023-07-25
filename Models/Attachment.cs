using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Attachment
{
	/// <summary>
	/// Attachment id
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// Name of file attached
	/// </summary>
	[JsonPropertyName( "filename" )]
	public string Filename { get; set; }

	/// <summary>
	/// Description for the file (max 1024 characters)
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The attachment's media type
	/// </summary>
	[JsonPropertyName( "content_type" )]
	public string ContentType { get; set; } = string.Empty;

	/// <summary>
	/// Size of file in bytes
	/// </summary>
	[JsonPropertyName( "size" )]
	public int Size { get; set; }

	/// <summary>
	/// Source url of file
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; }

	/// <summary>
	/// A proxied url of file
	/// </summary>
	[JsonPropertyName( "proxy_url" )]
	public string ProxyUrl { get; set; }

	/// <summary>
	///	Height of file (if image)
	/// </summary>
	[JsonPropertyName( "height" )]
	public int Height { get; set; }

	/// <summary>
	///	Width of file (if image)
	/// </summary>
	[JsonPropertyName( "width" )]
	public int Width { get; set; }

	/// <summary>
	///	Whether this attachment is ephemeral
	/// </summary>
	[JsonPropertyName( "ephemeral" )]
	public bool Ephemeral { get; set; } = false;

	/// <summary>
	///	The duration of the audio file (currently for voice messages)
	/// </summary>
	[JsonPropertyName( "duration_secs" )]
	public float DurationSecs { get; set; } = 0f;

	/// <summary>
	///	Base64 encoded bytearray representing a sampled waveform (currently for voice messages)
	/// </summary>
	[JsonPropertyName( "waveform" )]
	public string Waveform { get; set; } = string.Empty;
}
