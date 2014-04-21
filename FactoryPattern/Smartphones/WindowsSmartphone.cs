using System;
using FactoryPattern.OperatingSystems;
using FactoryPattern.Apps;

namespace FactoryPattern.Smartphones
{
	public class WindowsSmartphone : Smartphone
	{
		//Factory method
		protected override SmartPhoneOS Setup (int year)
		{
			SmartPhoneOS smartphoneOS = null;
			AppFactory appFactory = new AppFactoryWindows ();

			if (year.Equals (2011)) 
			{
				smartphoneOS = new WindowsMango (appFactory);
				smartphoneOS.Name = "Windows Mango";
			} 
			else if (year.Equals (2012)) 
			{
				smartphoneOS = new WindowsApollo (appFactory);
				smartphoneOS.Name = "Windows Apollo";
			} 
			else if (year.Equals (2014)) 
			{
				smartphoneOS = new WindowsBlue (appFactory);
				smartphoneOS.Name = "Windows Blue";
			} 
			return smartphoneOS;
		}
	}
}

