using System.Text.Json.Serialization;

namespace Mbk.Discord.Models;

public class RoleSubscriptionData
{
	/// <summary>
	/// The id of the sku and listing that the user is subscribed to
	/// </summary>
	[JsonPropertyName( "role_subscription_listing_id" )]
	public long RoleSubscrptionListingID { get; set; }

	/// <summary>
	/// The name of the tier that the user is subscribed to
	/// </summary>
	[JsonPropertyName( "tier_name" )]
	public string TierName { get; set; }

	/// <summary>
	/// The cumulative number of months that the user has been subscribed for
	/// </summary>
	[JsonPropertyName( "total_months_subscribed" )]
	public int TotalMonthsSubscribed { get; set; }

	/// <summary>
	/// Whether this notification is for a renewal rather than a new purchase
	/// </summary>
	[JsonPropertyName( "is_renewal" )]
	public bool IsRenewal { get; set; }
}
