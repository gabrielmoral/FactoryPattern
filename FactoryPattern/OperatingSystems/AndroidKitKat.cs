using System;

namespace FactoryPattern.OperatingSystems
{
	public class AndroidKitKat : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Kit Kat";
		}
	}
}

