using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern.OperatingSystems
{
	public class WindowsBlue : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Blue";
		}
	}
}

