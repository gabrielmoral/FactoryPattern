using System;
using FactoryPattern.Apps.WindowsApps;

namespace FactoryPattern.Apps
{
	//Abstract factory
	public class AppFactoryWindows : AppFactory
	{
		public EmailApp StartEmailApp ()
		{
			return new HotmailApp ();
		}

		public BrowserApp StartBrowserApp ()
		{
			return new InternetExplorerApp ();
		}
			
	}
}

