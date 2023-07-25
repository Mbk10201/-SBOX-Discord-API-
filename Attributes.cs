namespace Mbk.Discord.Attributes;

[AttributeUsage( AttributeTargets.Method )]
public class DiscordGameEvent : Attribute
{
	public string Name { get; set; }
	public string Identifier { get; set; }
	public string Description { get; set; }

	public DiscordGameEvent( string name, string identifier, string description)
	{
		Name = name;
		Identifier = identifier;
		Description = description;
	}
}
