using MvvmCross.ViewModels;
using SampleApp.Core.ViewModels;

namespace SampleApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<StartViewModel>();
        }
    }
}
