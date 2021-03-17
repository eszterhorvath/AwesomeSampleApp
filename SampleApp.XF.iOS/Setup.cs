using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using SampleApp.Core;
using SampleApp.Core.Services;
using SampleApp.UI;
using UIKit;

namespace SampleApp.XF.iOS
{
    public class Setup : MvxFormsIosSetup<App, FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<INativeThemeService, iOSThemeService>();
        }
    }
}