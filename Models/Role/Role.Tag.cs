﻿using System.Text.Json.Serialization;

namespace DiscordAPI.Models;

public class RoleTag
{
	/// <summary>
	/// The id of the bot this role belongs to
	/// </summary>
	[JsonPropertyName( "bot_id" )]
	public long? BotID { get; set; }

	/// <summary>
	/// The id of the integration this role belongs to
	/// </summary>
	[JsonPropertyName( "integration_id" )]
	public long? IntegrationID { get; set; }

	/// <summary>
	/// Whether this is the guild's Booster role
	/// </summary>
	[JsonPropertyName( "premium_subscriber" )]
	public bool? PremiumSubscriber { get; set; }

	/// <summary>
	///	The id of this role's subscription sku and listing
	/// </summary>
	[JsonPropertyName( "subscription_listing_id" )]
	public long? SubscriptionListing { get; set; }

	/// <summary>
	///	Whether this role is available for purchase
	/// </summary>
	[JsonPropertyName( "available_for_purchase" )]
	public bool? AvailableForPurchase { get; set; }

	/// <summary>
	///	Whether this role is a guild's linked role
	/// </summary>
	[JsonPropertyName( "guild_connections" )]
	public bool? GuildConnections { get; set; }
}