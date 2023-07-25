namespace Mbk.Discord.Enums;

[Flags]
public enum GuildMemberFlags
{
	/// <summary>
	/// Member has left and rejoined the guild
	/// </summary>
	DID_REJOIN = 0,

	/// <summary>
	/// Member has completed onboarding
	/// </summary>
	COMPLETED_ONBOARDING = 1,

	/// <summary>
	/// Member is exempt from guild verification requirements
	/// </summary>
	BYPASSES_VERIFICATION = 2,

	/// <summary>
	/// Member has started onboarding	
	/// </summary>
	STARTED_ONBOARDING = 3
}
