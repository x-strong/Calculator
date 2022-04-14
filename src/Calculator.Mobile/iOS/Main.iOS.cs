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
			if (string.IsNullOrEmpty(System.Threading.Thread.CurrentThread.CurrentCulture.Name))
			{
				var language = Foundation.NSLocale.PreferredLanguages.ElementAtOrDefault(0);

				try
				{
					var cultureInfo = CultureInfo.CreateSpecificCulture(language);
					CultureInfo.CurrentUICulture = cultureInfo;
					CultureInfo.CurrentCulture = cultureInfo;
					System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
					System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
				}
				catch (Exception ex)
				{
					this.Log().Error($"Failed to set culture for language: {language}", ex);
				}
			}
#endif
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, typeof(App));
		}
	}
}
