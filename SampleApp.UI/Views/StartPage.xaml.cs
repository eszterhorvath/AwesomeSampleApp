using System;
using SampleApp.Core.ViewModels;

namespace SampleApp.UI.Views
{
    public partial class StartPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void NavigateToThemeTestPage(object sender, EventArgs e)
        {
            if (BindingContext?.DataContext is StartViewModel vm)
            {
                Dispatcher.BeginInvokeOnMainThread(vm.NavigateToThemeTestViewModelAsync);
            }
        }

        private void NavigateToImageLoadingTestPage(object sender, EventArgs e)
        {
            if (BindingContext?.DataContext is StartViewModel vm)
            {
                Dispatcher.BeginInvokeOnMainThread(vm.NavigateToImageLoadingTestViewModelAsync);
            }
        }
    }
}