using System;
using FactoryPattern.Smartphones;

namespace FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Smartphone smartphoneAndroid = new AndroidSmartphone();
			Smartphone smartphoneWindows = new WindowsSmartphone();

			smartphoneAndroid.StartOperatingSystem (2012);

			smartphoneWindows.StartOperatingSystem (2012);

			Console.Read();
		}
	}
}

