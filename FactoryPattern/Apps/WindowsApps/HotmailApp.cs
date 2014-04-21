using System;

namespace FactoryPattern.Apps.WindowsApps
{
	public class HotmailApp : EmailApp
	{
		public string GetName ()
		{
			return "Hotmail app";
		}
	}
}

