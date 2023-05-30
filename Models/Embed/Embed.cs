using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord.Models;

public class Embed
{
	/// <summary>
	///	Title of embed
	/// </summary>
	[JsonPropertyName( "title" )]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	///	Type of embed (always "rich" for webhook embeds)
	/// </summary>
	[JsonPropertyName( "type" )]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	///	Description of embed
	/// </summary>
	[JsonPropertyName( "description" )]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	///	Url of embed
	/// </summary>
	[JsonPropertyName( "url" )]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	///	Timestamp of embed content
	/// </summary>
	[JsonPropertyName( "timestamp" )]
	public RealTimeSince? Timestamp { get; set; }

	/// <summary>
	///	Color code of the embed
	/// </summary>
	[JsonPropertyName( "color" )]
	public int? Color { get; set; }

	/// <summary>
	///	Footer information
	/// </summary>
	[JsonPropertyName( "footer" )]
	public EmbedFooter Footer { get; set; } = null;

	/// <summary>
	///	Image information
	/// </summary>
	[JsonPropertyName( "image" )]
	public EmbedImage Image { get; set; } = null;

	/// <summary>
	///	Thumbnail information
	/// </summary>
	[JsonPropertyName( "thumbnail" )]
	public EmbedThumbnail Thumbnail { get; set; } = null;

	/// <summary>
	///	Video information
	/// </summary>
	[JsonPropertyName( "video" )]
	public EmbedVideo Video { get; set; } = null;

	/// <summary>
	///	Provider information
	/// </summary>
	[JsonPropertyName( "provider" )]
	public EmbedProvider Provider { get; set; } = null;

	/// <summary>
	///	Author information
	/// </summary>
	[JsonPropertyName( "author" )]
	public EmbedAuthor Author { get; set; } = null;

	/// <summary>
	///	Fields information
	/// </summary>
	[JsonPropertyName( "fields" )]
	public List<EmbedField> Fields { get; set; } = null;

	public Embed()
	{
		// I dont know if i have to initialise it cuz the json charge data if not null directly on it so i have to test.
		//Fields = new();
	}
}
