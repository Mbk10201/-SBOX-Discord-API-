using DiscordAPI.Models;
using Sandbox;

namespace DiscordAPI;

public static partial class Discord
{
	//---------------------------------------------------------------------

	public const string OnChannelMessage = "onchannelmessage";

	public class OnChannelMessageAttribute : EventAttribute
	{
		public OnChannelMessageAttribute() : base( OnChannelMessage ) { }
	}

	//---------------------------------------------------------------------

	public const string OnGetReactions = "ongetreactions";

	public class OnGetReactionsAttribute : EventAttribute
	{
		public OnGetReactionsAttribute() : base( OnGetReactions ) { }
	}

	//---------------------------------------------------------------------

	public const string OnMessageSent = "onmessagesend";

	public class OnMessageSentAttribute : EventAttribute
	{
		public OnMessageSentAttribute() : base( OnMessageSent ) { }
	}

	//---------------------------------------------------------------------

	public const string OnMessageDeleted = "onmessagedeleted";

	public class OnMessageDeletedAttribute : EventAttribute
	{
		public OnMessageDeletedAttribute() : base( OnMessageDeleted ) { }
	}

	//---------------------------------------------------------------------

	public const string OnGetMembers = "ongetmembers";

	public class OnGetMembersAttribute : EventAttribute
	{
		public OnGetMembersAttribute() : base( OnGetMembers ) { }
	}
}
