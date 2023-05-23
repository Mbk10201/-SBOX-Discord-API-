using Sandbox;
using System;
using System.Linq;

namespace DiscordAPI;

public static partial class Discord
{
	//---------------------------------------------------------------------

	[AttributeUsage( AttributeTargets.Method )]
	public class RegisterDiscordEvent : Attribute
	{
		public string Name { get; set; }
		public string Identifier { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		
		public RegisterDiscordEvent( string name, string identifier, string description, string category = "general" )
		{
			Name = name;
			Identifier = identifier;
			Description = description;
			Category = category;
		}
	}

	//---------------------------------------------------------------------
}
