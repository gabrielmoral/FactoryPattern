using System;
using FactoryPattern.OperatingSystems;
using FactoryPattern.Apps;

namespace FactoryPattern.OperatingSystems
{
	public class WindowsApollo : SmartPhoneOS
	{
		private AppFactory appFactory;

		public WindowsApollo(AppFactory appFactory)
		{
			this.appFactory = appFactory;
		}

		public override void StartApps ()
		{
			this.EmailApp = appFactory.StartEmailApp ();
			this.BrowserApp = appFactory.StartBrowserApp ();

			Console.WriteLine (this.EmailApp.GetName () + ", " + this.BrowserApp.GetName () + " have been started...");
		}
	}
}

