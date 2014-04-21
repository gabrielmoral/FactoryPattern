using System;

namespace FactoryPattern.Apps.WindowsApps
{
	public class InternetExplorerApp : BrowserApp
	{
		public string GetName ()
		{
			return "Internet Explorer app";
		}
	}
}

