using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern.OperatingSystems
{
	public class WindowsMango : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Mango";
		}
	}
}

