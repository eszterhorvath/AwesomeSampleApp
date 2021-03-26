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
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using SampleApp.UI;

namespace SampleApp.XF.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.App, FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

        }
    }
}