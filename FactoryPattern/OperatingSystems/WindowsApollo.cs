using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern.OperatingSystems
{
	public class WindowsApollo : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Apollo";
		}
	}
}

