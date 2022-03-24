using System;
using SampleApp.Core.ViewModels;

namespace SampleApp.UI.Views
{
    public partial class ImageLoadingTestPage
    {
        public ImageLoadingTestPage()
        {
            InitializeComponent();
        }
        private void PickPicture(object sender, EventArgs e)
        {
            if (BindingContext?.DataContext is ImageLoadingTestViewModel vm)
            {
                Dispatcher.BeginInvokeOnMainThread(vm.PickPictureAsync);
            }
        }

        private void TakePicture(object sender, EventArgs e)
        {
            if (BindingContext?.DataContext is ImageLoadingTestViewModel vm)
            {
                Dispatcher.BeginInvokeOnMainThread(vm.TakePictureAsync);
            }
        }
    }
}