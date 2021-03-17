using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using SampleApp.Core;
using SampleApp.UI;
using UIKit;

namespace SampleApp.XF.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxFormsApplicationDelegate<Setup, App, FormsApp>
    {
       
    }
}


