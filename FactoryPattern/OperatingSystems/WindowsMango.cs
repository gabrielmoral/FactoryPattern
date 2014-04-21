using System;
using FactoryPattern.OperatingSystems;
using FactoryPattern.Apps;

namespace FactoryPattern.OperatingSystems
{
	public class WindowsMango : SmartPhoneOS
	{
		private AppFactory appFactory;

		public WindowsMango(AppFactory appFactory)
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

