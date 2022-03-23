using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace SampleApp.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        public StartViewModel(IMvxNavigationService navigation)
        {
            OpenThemeTester = new MvxCommand(async () =>
            {
                await navigation.Navigate<ThemeTestViewModel>();
            });
        }

        public IMvxCommand OpenThemeTester { get; set; }
    }
}
