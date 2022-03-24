using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using ReactiveUI;

namespace SampleApp.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        public StartViewModel(IMvxNavigationService navigation)
        {
            OpenThemeTesterCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await navigation.Navigate<ThemeTestViewModel>();
            });
            OpenImageLoadingTesterCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await navigation.Navigate<ImageLoadingTestViewModel>();
            });
        }

        public IReactiveCommand OpenThemeTesterCommand { get; set; }
        public IReactiveCommand OpenImageLoadingTesterCommand { get; set; }
    }
}
