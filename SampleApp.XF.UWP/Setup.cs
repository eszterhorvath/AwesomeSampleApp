using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Forms.Platforms.Uap.Core;
using SampleApp.Core.Services;
using SampleApp.UI;

namespace SampleApp.XF.UWP
{
    public class Setup : MvxFormsWindowsSetup<Core.App, FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<INativeThemeService, UWPThemeService>();
        }
    }
}
