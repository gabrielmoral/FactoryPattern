using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern.Smartphones
{
	public abstract class Smartphone
	{
		//Factory method
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

