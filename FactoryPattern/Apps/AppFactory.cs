using System;

namespace FactoryPattern.Apps
{
	//Abstract factory
	public interface AppFactory
	{
		EmailApp StartEmailApp();

		BrowserApp StartBrowserApp();
	}
}

