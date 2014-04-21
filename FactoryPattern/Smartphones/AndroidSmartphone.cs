using System;
using FactoryPattern.Apps;
using FactoryPattern.OperatingSystems;

namespace FactoryPattern.Smartphones
{
	public class AndroidSmartphone : Smartphone
	{
		//Factory method
		protected override SmartPhoneOS Setup (int year)
		{
			SmartPhoneOS smartphoneOS = null;
			AppFactory appFactory = new AppFactoryAndroid ();

			if (year.Equals (2011)) 
			{
				smartphoneOS = new AndroidIceCream (appFactory);
				smartphoneOS.Name = "Android Ice Cream";
			} 
			else if (year.Equals (2012)) 
			{
				smartphoneOS = new AndroidJellyBean (appFactory);
				smartphoneOS.Name = "Android Jelly Bean";
			} 
			else if (year.Equals (2013)) 
			{
				smartphoneOS = new AndroidKitKat (appFactory);
				smartphoneOS.Name = "Android Kit Kat";
			} 

			return smartphoneOS;
		}
	}
}

