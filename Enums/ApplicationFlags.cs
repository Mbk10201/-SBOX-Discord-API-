namespace Mbk.Discord.Enums;

[Flags]
public enum ApplicationFlags
{
	/// <summary>
	/// Indicates if an app uses the Auto Moderation API
	/// </summary>
	APPLICATION_AUTO_MODERATION_RULE_CREATE_BADGE = 6,

	/// <summary>
	/// Intent required for bots in 100 or more servers to receive presence_update events
	/// </summary>
	GATEWAY_PRESENCE = 12,

	/// <summary>
	/// Intent required for bots in under 100 servers to receive presence_update events, found on the Bot page in your app's settings
	/// </summary>
	GATEWAY_PRESENCE_LIMITED = 13,

	/// <summary>
	/// Intent required for bots in 100 or more servers to receive member-related events like guild_member_add. See the list of member-related events under GUILD_MEMBERS
	/// </summary>
	GATEWAY_GUILD_MEMBERS = 14,

	/// <summary>
	/// Intent required for bots in under 100 servers to receive member-related events like guild_member_add, found on the Bot page in your app's settings. See the list of member-related events under GUILD_MEMBERS
	/// </summary>
	GATEWAY_GUILD_MEMBERS_LIMITED = 15,

	/// <summary>
	/// Indicates unusual growth of an app that prevents verification
	/// </summary>
	VERIFICATION_PENDING_GUILD_LIMIT = 16,

	/// <summary>
	/// Indicates if an app is embedded within the Discord client (currently unavailable publicly)
	/// </summary>
	EMBEDDED = 17,

	/// <summary>
	/// Intent required for bots in 100 or more servers to receive message content
	/// </summary>
	GATEWAY_MESSAGE_CONTENT = 18,

	/// <summary>
	/// Intent required for bots in under 100 servers to receive message content, found on the Bot page in your app's settings
	/// </summary>
	GATEWAY_MESSAGE_CONTENT_LIMITED = 19,

	/// <summary>
	/// Indicates if an app has registered global application commands
	/// </summary>
	APPLICATION_COMMAND_BADGE = 23
}
