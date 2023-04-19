using Core.DI;
using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace MvvmExampleiOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.

    //[Register(nameof(AppDelegate))]
    [Register ("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    //public class AppDelegate : UIResponder, IUIApplicationDelegate {
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            return result;
        }
    }
}


