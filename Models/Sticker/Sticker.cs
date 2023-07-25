using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class Sticker
{
	/// <summary>
	/// Id of the sticker
	/// </summary>
	[JsonPropertyName( "id" )]
	public object Id { get; set; } = null;

	/// <summary>
	/// For standard stickers, id of the pack the sticker is from
	/// </summary>
	[JsonPropertyName( "pack_id" )]
	public object PackID { get; set; } = null;

	/// <summary>
	/// Name of the sticker
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// Description of the sticker
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; }

	/// <summary>
	/// Autocomplete/suggestion tags for the sticker (max 200 characters)
	/// </summary>
	[JsonPropertyName( "tags" )]
	public string Tags { get; set; }

	/// <summary>
	/// Autocomplete/suggestion tags for the sticker (max 200 characters)
	/// </summary>
	[JsonPropertyName( "asset" )]
	public string Asset { get; set; } = string.Empty;

	/// <summary>
	///	Type of sticker format
	/// </summary>
	[JsonPropertyName( "format_type" )]
	public StickerFormatType Type { get; set; }

	/// <summary>
	///	Whether this guild sticker can be used, may be false due to loss of Server Boosts
	/// </summary>
	[JsonPropertyName( "available" )]
	public bool? Available { get; set; }

	/// <summary>
	///	Id of the guild that owns this sticker
	/// </summary>
	[JsonPropertyName( "guild_id" )]
	public object GuildID { get; set; } = null;

	/// <summary>
	///	The user that uploaded the guild sticker
	/// </summary>
	[JsonPropertyName( "user_id" )]
	public User user { get; set; } = null;

	/// <summary>
	///	The standard sticker's sort order within its pack
	/// </summary>
	[JsonPropertyName( "sort_value" )]
	public int? SortValue { get; set; }
}
