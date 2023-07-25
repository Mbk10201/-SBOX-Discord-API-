using Mbk.Discord.Enums;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class MessageInteraction
{
	/// <summary>
	/// ID of the interaction
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// Type of interaction
	/// </summary>
	[JsonPropertyName( "type" )]
	public InteractionType Type { get; set; }

	/// <summary>
	///	Name of the application command, including subcommands and subcommand groups
	/// </summary>
	[JsonPropertyName( "name" )]
	public string Name { get; set; }

	/// <summary>
	///	User who invoked the interaction
	/// </summary>
	[JsonPropertyName( "user" )]
	public User User { get; set; }

	/// <summary>
	///	Member who invoked the interaction in the guild
	/// </summary>
	[JsonPropertyName( "member" )]
	public GuildMember Member { get; set; }
}
