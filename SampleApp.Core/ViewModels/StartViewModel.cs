using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace SampleApp.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigation;

        public StartViewModel(IMvxNavigationService navigation)
        {
            _navigation = navigation;
        }

        public async void NavigateToThemeTestViewModelAsync()
        {
            await _navigation.Navigate<ThemeTestViewModel>();
        }
        public async void NavigateToImageLoadingTestViewModelAsync()
        {
            await _navigation.Navigate<ImageLoadingTestViewModel>();
        }
    }
}
