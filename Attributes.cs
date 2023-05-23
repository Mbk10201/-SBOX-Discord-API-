using Sandbox;
using System;
using System.Linq;

namespace DiscordAPI;

public partial class DiscordAPI
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

			if ( !EventList.Exists( x => x.Identifier == identifier ) )
			{
				RegisterEvent( new()
				{
					Identifier = identifier,
					Name = name,
					Description = description,
					Category = category
				} );
			}
		}
	}

	//---------------------------------------------------------------------
}
