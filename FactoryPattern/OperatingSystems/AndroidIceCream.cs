using System;

namespace FactoryPattern.OperatingSystems
{
	public class AndroidIceCream : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Ice Cream";
		}
	}
}

