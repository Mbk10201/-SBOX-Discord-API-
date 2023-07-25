using Mbk.Discord.Models;

namespace Mbk.Discord;

public partial class Client
{
	/// <summary>
	/// GUILD_CREATE
	/// Dispatched when the bot joins a new guild or when the guild becomes available during a session.
	/// </summary>

	private const string OnGuildCreate = "GUILD_CREATE";

	[MethodArguments( new Type[] { typeof( Guild ) } )]
	public class OnGuildCreateAttribute : EventAttribute
	{
		public OnGuildCreateAttribute() : base( OnGuildCreate ) { }
	}

	/// <summary>
	/// GUILD_UPDATE
	/// Dispatched when a guild is updated (edited).
	/// </summary>

	private const string OnGuildUpdate = "GUILD_UPDATE";

	[MethodArguments( new Type[] { typeof( Guild ) } )]
	public class OnGuildUpdateAttribute : EventAttribute
	{
		public OnGuildUpdateAttribute() : base( OnGuildUpdate ) { }
	}

	/// <summary>
	/// GUILD_DELETE
	/// Dispatched when a guild is deleted or becomes unavailable.
	/// </summary>

	private const string OnGuildDelete = "GUILD_DELETE";

	[MethodArguments( new Type[] { typeof( Guild ) } )]
	public class OnGuildDeleteAttribute : EventAttribute
	{
		public OnGuildDeleteAttribute() : base( OnGuildDelete ) { }
	}

	/// <summary>
	/// GUILD_MEMBER_ADD
	/// Dispatched when a new member joins a guild.
	/// </summary>

	private const string OnGuildMemberAdd = "GUILD_MEMBER_ADD";

	[MethodArguments( new Type[] { typeof( GuildMember ) } )]
	public class OnGuildMemberAddAttribute : EventAttribute
	{
		public OnGuildMemberAddAttribute() : base( OnGuildMemberAdd ) { }
	}

	/// <summary>
	/// GUILD_MEMBER_UPDATE
	/// Dispatched when a guild member is updated (edited).
	/// </summary>

	private const string OnGuildMemberUpdate = "GUILD_MEMBER_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildMember ) } )]
	public class OnGuildMemberUpdateAttribute : EventAttribute
	{
		public OnGuildMemberUpdateAttribute() : base( OnGuildMemberUpdate ) { }
	}

	/// <summary>
	/// GUILD_MEMBER_REMOVE
	/// Dispatched when a member leaves or is removed from a guild.
	/// </summary>

	private const string OnGuildMemberRemove = "GUILD_MEMBER_REMOVE";

	[MethodArguments( new Type[] { typeof( GuildMember ) } )]
	public class OnGuildMemberRemoveAttribute : EventAttribute
	{
		public OnGuildMemberRemoveAttribute() : base( OnGuildMemberUpdate ) { }
	}

	/// <summary>
	/// GUILD_ROLE_CREATE
	/// Dispatched when a new role is created in a guild.
	/// </summary>

	private const string OnGuildRoleCreate = "GUILD_ROLE_CREATE";

	[MethodArguments( new Type[] { typeof( GuildRole ) } )]
	public class OnGuildRoleCreateAttribute : EventAttribute
	{
		public OnGuildRoleCreateAttribute() : base( OnGuildRoleCreate ) { }
	}

	/// <summary>
	/// GUILD_ROLE_UPDATE
	/// Dispatched when a role is updated (edited) in a guild.
	/// </summary>

	private const string OnGuildRoleUpdate = "GUILD_ROLE_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildRole ) } )]
	public class OnGuildRoleUpdateAttribute : EventAttribute
	{
		public OnGuildRoleUpdateAttribute() : base( OnGuildRoleUpdate ) { }
	}

	/// <summary>
	/// GUILD_ROLE_DELETE
	/// Dispatched when a role is updated (edited) in a guild.
	/// </summary>

	private const string OnGuildRoleDelete = "GUILD_ROLE_DELETE";

	[MethodArguments( new Type[] { typeof( GuildRole ) } )]
	public class OnGuildRoleDeleteAttribute : EventAttribute
	{
		public OnGuildRoleDeleteAttribute() : base( OnGuildRoleDelete ) { }
	}

	/// <summary>
	/// GUILD_BAN_ADD
	/// Dispatched when a user is banned from a guild.
	/// </summary>

	private const string OnGuildBanAdd = "GUILD_BAN_ADD";

	[MethodArguments( new Type[] { typeof( GuildMember ) } )]
	public class OnGuildBanAddAttribute : EventAttribute
	{
		public OnGuildBanAddAttribute() : base( OnGuildBanAdd ) { }
	}

	/// <summary>
	/// GUILD_BAN_ADD
	/// Dispatched when a user's ban is lifted in a guild.
	/// </summary>

	private const string OnGuildBanRemove = "GUILD_BAN_REMOVE";

	[MethodArguments( new Type[] { typeof( GuildMember ) } )]
	public class OnGuildBanRemoveAttribute : EventAttribute
	{
		public OnGuildBanRemoveAttribute() : base( OnGuildBanRemove ) { }
	}

	/// <summary>
	/// GUILD_EMOJIS_UPDATE
	/// Dispatched when the available emojis in a guild are updated.
	/// </summary>

	private const string OnGuildEmojisUpdate = "GUILD_EMOJIS_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildEmojiUpdate ) } )]
	public class OnGuildEmojisUpdateAttribute : EventAttribute
	{
		public OnGuildEmojisUpdateAttribute() : base( OnGuildEmojisUpdate ) { }
	}

	/// <summary>
	/// GUILD_INTEGRATIONS_UPDATE
	/// Dispatched when the integrations in a guild are updated.
	/// </summary>

	private const string OnGuildIntegrationsUpdate = "GUILD_INTEGRATIONS_UPDATE";

	[MethodArguments( new Type[] { typeof( Guild ) } )]
	public class OnGuildIntegrationsUpdateAttribute : EventAttribute
	{
		public OnGuildIntegrationsUpdateAttribute() : base( OnGuildIntegrationsUpdate ) { }
	}

	/// <summary>
	/// GUILD_MEMBERS_CHUNK
	/// Dispatched in response to a Request Guild Members payload, providing a chunk of guild members.
	/// </summary>

	private const string OnGuildMembersChunk = "GUILD_MEMBERS_CHUNK";

	[MethodArguments( new Type[] { typeof( Guild ) } )]
	public class OnGuildMembersChunkAttribute : EventAttribute
	{
		public OnGuildMembersChunkAttribute() : base( OnGuildMembersChunk ) { }
	}
}
