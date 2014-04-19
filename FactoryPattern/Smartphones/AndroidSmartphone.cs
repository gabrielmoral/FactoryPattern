using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern
{
	public class AndroidSmartphone : Smartphone
	{
		protected override SmartPhoneOS Setup (int year)
		{
			SmartPhoneOS smartphoneOS;

			if (year.Equals (2011)) 
			{
				smartphoneOS = new AndroidIceCream ();
			} 
			else if (year.Equals (2012)) 
			{
				smartphoneOS = new AndroidJellyBean ();
			} 
			else if (year.Equals (2013)) 
			{
				smartphoneOS = new AndroidKitKat ();
			} 
			else 
			{
				smartphoneOS = null;
			}

			return smartphoneOS;
		}
	}
}

