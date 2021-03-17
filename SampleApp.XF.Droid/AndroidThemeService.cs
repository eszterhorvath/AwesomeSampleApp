using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApp.Core.Services;
using SampleApp.Core.ViewModels;

namespace SampleApp.XF.Droid
{
    public class AndroidThemeService : INativeThemeService
    {
        public Theme GetSystemTheme()
        {
            throw new NotImplementedException();
        }
    }
}