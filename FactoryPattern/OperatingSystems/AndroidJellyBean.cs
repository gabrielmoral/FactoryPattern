using System;

namespace FactoryPattern.OperatingSystems
{
	public class AndroidJellyBean : SmartPhoneOS
	{
		protected override string getName ()
		{
			return "Jelly Bean";
		}
	}
}

