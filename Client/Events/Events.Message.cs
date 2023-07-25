using Mbk.Discord.Models;

namespace Mbk.Discord;

public partial class Client
{
	/// <summary>
	/// MESSAGE_CREATE
	/// Dispatched when a new message is created in a text channel.
	/// </summary>

	private const string OnMessageCreate = "MESSAGE_CREATE";

	[MethodArguments( new Type[] { typeof( Message ) } )]
	public class OnMessageCreateAttribute : EventAttribute
	{
		public OnMessageCreateAttribute() : base( OnMessageCreate ) { }
	}

	/// <summary>
	/// MESSAGE_UPDATE
	/// Dispatched when a message is updated (edited) in a text channel.
	/// </summary>

	private const string OnMessageUpdate = "MESSAGE_UPDATE";

	[MethodArguments( new Type[] { typeof( Message ) } )]
	public class OnMessageUpdateAttribute : EventAttribute
	{
		public OnMessageUpdateAttribute() : base( OnMessageUpdate ) { }
	}

	/// <summary>
	/// MESSAGE_DELETE
	/// Dispatched when a message is deleted in a text channel.
	/// </summary>

	private const string OnMessageDelete = "MESSAGE_DELETE";

	[MethodArguments( new Type[] { typeof( Message ) } )]
	public class OnMessageDeleteAttribute : EventAttribute
	{
		public OnMessageDeleteAttribute() : base( OnMessageDelete ) { }
	}

	/// <summary>
	/// MESSAGE_DELETE_BULK
	/// Dispatched when multiple messages are deleted in a text channel.
	/// </summary>

	private const string OnMessageDeleteBulk = "MESSAGE_DELETE_BULK";

	[MethodArguments( new Type[] { typeof( List<Message> ) } )]
	public class OnMessageDeleteBulkAttribute : EventAttribute
	{
		public OnMessageDeleteBulkAttribute() : base( OnMessageDeleteBulk ) { }
	}
}
