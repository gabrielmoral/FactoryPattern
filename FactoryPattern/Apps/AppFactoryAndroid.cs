using System;
using FactoryPattern.Apps.AndroidApps;

namespace FactoryPattern.Apps
{
	//Abstract factory
	public class AppFactoryAndroid : AppFactory
	{
		public EmailApp StartEmailApp ()
		{
			return new GmailApp ();
		}
			
		public BrowserApp StartBrowserApp ()
		{
			return new ChromeApp ();
		}

	}
}

