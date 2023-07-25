using Mbk.Discord.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class StickerItem
{
	/// <summary>
	/// Id of the sticker
	/// </summary>
	[JsonPropertyName( "id" )]
	public long? Id { get; set; }

	/// <summary>
	/// Name of the sticker
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	///	Type of sticker format
	/// </summary>
	[JsonPropertyName( "format_type" )]
	public StickerFormatType FormatType { get; set; }
}
