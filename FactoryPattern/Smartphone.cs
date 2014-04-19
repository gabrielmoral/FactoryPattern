using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern
{
	public abstract class Smartphone
	{
		protected abstract SmartPhoneOS Setup (int year);

		public SmartPhoneOS StartOperatingSystem(int year)
		{
			SmartPhoneOS smartphoneOS = this.Setup (year);

			smartphoneOS.CreateUserInterface ();
			smartphoneOS.StartApps ();
			smartphoneOS.UserWelcome ();

			return smartphoneOS;
		}
	}
}

