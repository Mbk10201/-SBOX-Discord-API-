namespace Mbk.Discord.Enums;

[Flags]
public enum ActivityFlags
{
	INSTANCE = 0,
	JOIN = 1,
	SPECTATE = 2,
	JOIN_REQUEST = 3,
	SYNC = 4,
	PLAY = 5,
	PARTY_PRIVACY_FRIENDS = 6,
	PARTY_PRIVACY_VOICE_CHANNEL = 7,
	EMBEDDED = 8,
}
