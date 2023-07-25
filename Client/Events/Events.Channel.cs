using Mbk.Discord.Models;

namespace Mbk.Discord;

public partial class Client
{
	/// <summary>
	/// CHANNEL_CREATE
	/// Dispatched when a new channel is created.
	/// </summary>

	private const string OnChannelCreate = "CHANNEL_CREATE";

	[MethodArguments( new Type[] { typeof( Channel ) } )]
	public class OnChannelCreateAttribute : EventAttribute
	{
		public OnChannelCreateAttribute() : base( OnChannelCreate ) { }
	}

	/// <summary>
	/// CHANNEL_UPDATE
	/// Dispatched when a channel is updated (edited).
	/// </summary>

	private const string OnChannelUpdate = "CHANNEL_UPDATE";

	[MethodArguments( new Type[] { typeof( Channel ) } )]
	public class OnChannelUpdateAttribute : EventAttribute
	{
		public OnChannelUpdateAttribute() : base( OnChannelUpdate ) { }
	}

	/// <summary>
	/// CHANNEL_DELETE
	/// Dispatched when a channel is deleted.
	/// </summary>

	private const string OnChannelDelete = "CHANNEL_DELETE";

	[MethodArguments( new Type[] { typeof( Channel ) } )]
	public class OnChannelDeleteAttribute : EventAttribute
	{
		public OnChannelDeleteAttribute() : base( OnChannelDelete ) { }
	}
}
