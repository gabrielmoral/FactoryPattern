using System;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern
{
	public class WindowsSmartphone : Smartphone
	{
		protected override SmartPhoneOS Setup (int year)
		{
			SmartPhoneOS smartphoneOS;

			if (year.Equals (2011)) 
			{
				smartphoneOS = new WindowsMango ();
			} 
			else if (year.Equals (2012)) 
			{
				smartphoneOS = new WindowsApollo ();
			} 
			else if (year.Equals (2014)) 
			{
				smartphoneOS = new WindowsBlue ();
			} 
			else 
			{
				smartphoneOS = null;
			}

			return smartphoneOS;
		}
	}
}

