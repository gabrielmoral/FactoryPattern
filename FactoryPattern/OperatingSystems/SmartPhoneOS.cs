using System;

namespace FactoryPattern.OperatingSystems
{
	public abstract class SmartPhoneOS
	{
		protected abstract string getName();

		public void CreateUserInterface ()
		{
			Console.WriteLine ("Creating user interface...");
		}

		public void StartApps ()
		{
			Console.WriteLine ("Starting apps...");
		}

		public void UserWelcome ()
		{
			Console.WriteLine ("Hello, I'm " + this.getName());
		}
	}
}

