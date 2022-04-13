using CalculatorApp;
using UIKit;

namespace Calculator
{
	public class EntryPoint
{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
#if NET6_0_OR_GREATER
			// https://github.com/xamarin/xamarin-macios/issues/14740
			if (System.Threading.Thread.CurrentThread.CurrentCulture.IsNeutralCulture)
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
			}
#endif
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, typeof(App));
		}
	}
}
