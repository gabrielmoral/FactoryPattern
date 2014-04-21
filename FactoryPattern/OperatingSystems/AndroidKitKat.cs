using System;
using FactoryPattern.Apps;

namespace FactoryPattern.OperatingSystems
{
	public class AndroidKitKat : SmartPhoneOS
	{
		private AppFactory appFactory;

		public AndroidKitKat(AppFactory appFactory)
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

