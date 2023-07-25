using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class EmbedField
{
	/// <summary>
	///	Name of the field
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	/// Value of the field
	/// </summary>
	[JsonPropertyName( "value" )]
	public string Value { get; set; }

	/// <summary>
	/// Whether or not this field should display inline
	/// </summary>
	[JsonPropertyName( "inline" )]
	public bool? Inline { get; set; } = false;
}
