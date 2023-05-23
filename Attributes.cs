using Sandbox;
using System;

namespace DiscordAPI;

public partial class DiscordAPI
{
	//---------------------------------------------------------------------

	[AttributeUsage( AttributeTargets.Method )]
	public class RegisterDiscordEvent : Attribute
	{
		public string Name { get; set; }
		public string Category { get; set; }

		public RegisterDiscordEvent( string name, string category )
		{
			Name = name;
			Category = category;
			//RegisterEventSetting()
		}
	}

	//---------------------------------------------------------------------
}
