using System;
using FactoryPattern.Apps;

namespace FactoryPattern.OperatingSystems
{
	public abstract class SmartPhoneOS
	{
		private string name = "Without name";

		public string Name
		{
			get 
			{
				return this.name;
			}
			set 
			{
				this.name = value;
			}
		}

		protected EmailApp EmailApp;

		protected BrowserApp BrowserApp;

		public abstract void StartApps ();

		public void CreateUserInterface ()
		{
			Console.WriteLine ("Creating user interface...");
		}

		public void UserWelcome ()
		{
			Console.WriteLine ("Hello, I'm " + this.name);
		}
	}
}

