﻿using DiscordAPI.Enums;
using Sandbox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class Message
{
	/// <summary>
	/// The id of the message
	/// </summary>
	[JsonPropertyName( "id" )]
	public long Id { get; set; }

	/// <summary>
	/// The id of the channel the message was sent in
	/// </summary>
	[JsonPropertyName( "channel_id" )]
	public long ChannelID { get; set; }

	/// <summary>
	/// The author of this message (not guaranteed to be a valid user, see below)
	/// </summary>
	[JsonPropertyName( "author" )]
	public User Author { get; set; }

	/// <summary>
	/// Contents of the message
	/// </summary>
	[JsonPropertyName( "content" )]
	public string Content { get; set; }

	/// <summary>
	/// 	when this message was sent
	/// </summary>
	[JsonPropertyName( "timestamp" )]
	public string Timestamp { get; set; } = string.Empty;

	/// <summary>
	/// When this message was edited (or null if never)
	/// </summary>
	[JsonPropertyName( "edited_timestamp" )]
	public string EditedTimestamp { get; set; } = string.Empty;

	/// <summary>
	/// Whether this was a TTS message
	/// </summary>
	[JsonPropertyName( "tts" )]
	public bool TTS { get; set; }

	/// <summary>
	/// Whether this message mentions everyone
	/// </summary>
	[JsonPropertyName( "mention_everyone" )]
	public bool MentionEveryone { get; set; }

	/// <summary>
	/// Users specifically mentioned in the message
	/// </summary>
	[JsonPropertyName( "mentions" )]
	public List<User> Mentions { get; set; }

	/// <summary>
	/// Roles specifically mentioned in this message
	/// </summary>
	[JsonPropertyName( "mention_roles" )]
	public List<Role> MentionRoles { get; set; }

	/// <summary>
	/// Any attached files
	/// </summary>
	[JsonPropertyName( "attachments" )]
	public List<Attachment> Attachments { get; set; }

	/// <summary>
	/// Any embedded content
	/// </summary>
	[JsonPropertyName( "embeds" )]
	public List<Embed> Embeds { get; set; }

	/// <summary>
	/// Reactions to the message
	/// </summary>
	[JsonPropertyName( "reactions" )]
	public List<Reaction> Reactions { get; set; }

	/// <summary>
	/// Used for validating a message was sent
	/// </summary>
	[JsonPropertyName( "nonce" )]
	public string Nonce { get; set; } = string.Empty;

	/// <summary>
	/// Whether this message is pinned
	/// </summary>
	[JsonPropertyName( "pinned" )]
	public bool Pinned { get; set; }

	/// <summary>
	/// If the message is generated by a webhook, this is the webhook's id
	/// </summary>
	[JsonPropertyName( "webhook_id" )]
	public long? WebhookID { get; set; }

	/// <summary>
	/// Type of message
	/// </summary>
	[JsonPropertyName( "type" )]
	public MessageTypes Type { get; set; }

	/// <summary>
	/// Sent with Rich Presence-related chat embeds
	/// </summary>
	[JsonPropertyName( "activity" )]
	public MessageActivity Activity { get; set; }

	/// <summary>
	/// Sent with Rich Presence-related chat embeds
	/// </summary>
	[JsonPropertyName( "application" )]
	public Application Application { get; set; } = null;

	/// <summary>
	/// If the message is an Interaction or application-owned webhook, this is the id of the application
	/// </summary>
	[JsonPropertyName( "application_id" )]
	public long ApplicationID { get; set; }

	/// <summary>
	/// If the message is an Interaction or application-owned webhook, this is the id of the application
	/// </summary>
	[JsonPropertyName( "message_reference" )]
	public MessageReference MessageReference { get; set; } = null;

	/// <summary>
	/// Message flags combined as a bitfield
	/// </summary>
	[JsonPropertyName( "flags" )]
	public MessageFlags? Flags { get; set; }

	/// <summary>
	/// The message associated with the message_reference
	/// </summary>
	[JsonPropertyName( "referenced_message" )]
	public Message ReferencedMessage { get; set; } = null;

	/// <summary>
	/// Sent if the message is a response to an Interaction
	/// </summary>
	[JsonPropertyName( "interaction" )]
	public MessageInteraction Interaction { get; set; } = null;

	/// <summary>
	/// The thread that was started from this message, includes thread member object
	/// </summary>
	[JsonPropertyName( "thread" )]
	public Channel Thread { get; set; } = null;

	/// <summary>
	/// Sent if the message contains stickers
	/// </summary>
	[JsonPropertyName( "sticker_items" )]
	public List<StickerItem> StickerItems { get; set; } = null;

	/// <summary>
	/// Deprecated the stickers sent with the message
	/// </summary>
	[JsonPropertyName( "stickers" )]
	public List<Sticker> Stickers { get; set; } = null;

	/// <summary>
	/// A generally increasing integer (there may be gaps or duplicates) that represents the approximate position of the message in a thread, it can be used to estimate the relative position of the message in a thread in company with total_message_sent on parent thread
	/// </summary>
	[JsonPropertyName( "position" )]
	public int? Position { get; set; }

	/// <summary>
	/// Data of the role subscription purchase or renewal that prompted this ROLE_SUBSCRIPTION_PURCHASE message
	/// </summary>
	[JsonPropertyName( "role_subscription_data" )]
	public RoleSubscriptionData RoleSubscriptionData { get; set; } = null;

	public Message()
	{
		Mentions = new();
		MentionRoles = new();
		Attachments = new();
	}
}
