using Mbk.Discord.Models;

namespace Mbk.Discord;

public partial class Client
{
	/// <summary>
	/// WEBHOOKS_UPDATE
	/// Dispatched when the webhooks in a guild are updated.
	/// </summary>

	private const string OnWebhooksUpdate = "WEBHOOKS_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildWebhookUpdate ) } )]
	public class OnWebhooksUpdateAttribute : EventAttribute
	{
		public OnWebhooksUpdateAttribute() : base( OnWebhooksUpdate ) { }
	}

	/// <summary>
	/// TYPING_START
	/// Dispatched when a user starts typing in a channel.
	/// </summary>

	private const string OnTypingStart = "TYPING_START";

	[MethodArguments( new Type[] { typeof( GuildTypingStart ) } )]
	public class OnTypingStartAttribute : EventAttribute
	{
		public OnTypingStartAttribute() : base( OnTypingStart ) { }
	}

	/// <summary>
	/// PRESENCE_UPDATE
	/// Dispatched when a user's presence (status, game activity) is updated.
	/// </summary>

	private const string OnPresenceUpdate = "PRESENCE_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildPresence ) } )]
	public class OnPresenceUpdateAttribute : EventAttribute
	{
		public OnPresenceUpdateAttribute() : base( OnPresenceUpdate ) { }
	}

	/// <summary>
	/// VOICE_STATE_UPDATE
	/// Dispatched when a user's voice state (joining, leaving, muting, etc.) is updated.
	/// </summary>

	private const string OnVoiceStateUpdate = "VOICE_STATE_UPDATE";

	[MethodArguments( new Type[] { typeof( VoiceState ) } )]
	public class OnVoiceStateUpdateAttribute : EventAttribute
	{
		public OnVoiceStateUpdateAttribute() : base( OnVoiceStateUpdate ) { }
	}

	/// <summary>
	/// VOICE_SERVER_UPDATE
	/// Dispatched when a voice server is updated.
	/// </summary>

	private const string OnVoiceServerUpdate = "VOICE_SERVER_UPDATE";

	[MethodArguments( new Type[] { typeof( GuildVoiceServerUpdate ) } )]
	public class OnVoiceServerUpdateAttribute : EventAttribute
	{
		public OnVoiceServerUpdateAttribute() : base( OnVoiceServerUpdate ) { }
	}

	/// <summary>
	/// INTERACTION_CREATE
	/// Dispatched when a user interacts with a command or component in an interaction-based application.
	/// </summary>

	private const string OnInteractionCreate = "INTERACTION_CREATE";

	[MethodArguments( new Type[] { typeof( GuildInteractionCreate ) } )]
	public class OnInteractionCreateAttribute : EventAttribute
	{
		public OnInteractionCreateAttribute() : base( OnInteractionCreate ) { }
	}
}
