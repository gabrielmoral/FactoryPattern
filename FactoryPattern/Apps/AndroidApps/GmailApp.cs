using System;

namespace FactoryPattern.Apps.AndroidApps
{
	public class GmailApp : EmailApp
	{
		public string GetName ()
		{
			return "Gmail app";
		}
	}
}

