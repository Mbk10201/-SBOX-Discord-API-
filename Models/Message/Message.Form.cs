using Mbk.Discord.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class MessageForm
{
	/// <summary>
	/// Message contents (up to 2000 characters)
	/// </summary>
	[JsonPropertyName( "content" )]
	public string Content { get; set; }

	/// <summary>
	/// Can be used to verify a message was sent (up to 25 characters). Value will appear in the Message Create event.
	/// </summary>
	[JsonPropertyName( "nonce" )]
	public string Nonce { get; set; } = null;

	/// <summary>
	/// True if this is a TTS message
	/// </summary>
	[JsonPropertyName( "tts" )]
	public bool? TTS { get; set; }

	/// <summary>
	/// Up to 10 rich embeds (up to 6000 characters)
	/// </summary>
	[JsonPropertyName( "embeds" )]
	public List<Embed> Embeds { get; set; } = null;

	/// <summary>
	/// Allowed mentions for the message
	/// </summary>
	[JsonPropertyName( "allowed_mentions" )]
	public List<Embed> AllowedMentions { get; set; } = null;

	/// <summary>
	/// Include to make your message a reply
	/// </summary>
	[JsonPropertyName( "message_reference" )]
	public MessageReference MessageReference { get; set; } = null;

	/// <summary>
	/// IDs of up to 3 stickers in the server to send in the message
	/// </summary>
	[JsonPropertyName( "sticker_ids" )]
	public List<long> StickerIds { get; set; } = null;

	/// <summary>
	///	JSON-encoded body of non-file params, only for multipart/form-data requests. See Uploading Files
	/// </summary>
	[JsonPropertyName( "payload_json" )]
	public string PayloadJson { get; set; } = null;

	/// <summary>
	///	Attachment objects with filename and description. See Uploading Files
	/// </summary>
	[JsonPropertyName( "attachments" )]
	public List<Attachment> Attachments { get; set; } = null;

	/// <summary>
	///	Message flags combined as a bitfield (only SUPPRESS_EMBEDS and SUPPRESS_NOTIFICATIONS can be set)
	/// </summary>
	[JsonPropertyName( "flags" )]
	public MessageFlags? Flags { get; set; }
}
