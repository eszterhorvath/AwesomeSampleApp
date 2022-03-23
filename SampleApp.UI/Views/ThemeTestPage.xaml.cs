using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.UI.Views
{
    public partial class ThemeTestPage
    {
        private readonly OSAppTheme _systemTheme;

        public ThemeTestPage()
        {
            InitializeComponent();

            _systemTheme = Application.Current.RequestedTheme;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ThemePicker.SelectedIndex = 0;
            ActualThemeLabel.Text = "System";
            SystemThemeLabel.Text = _systemTheme.ToString();

            ThemePicker.SelectedIndexChanged += OnPickerSelectedItemChanged;
        }

        protected override void OnDisappearing()
        {
            ThemePicker.SelectedIndexChanged -= OnPickerSelectedItemChanged;

            base.OnDisappearing();
        }

        private void OnPickerSelectedItemChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedIndex = picker.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    Application.Current.UserAppTheme = _systemTheme;
                    ActualThemeLabel.Text = "System";
                    break;
                case 1:
                    Application.Current.UserAppTheme = OSAppTheme.Dark;
                    ActualThemeLabel.Text = OSAppTheme.Dark.ToString();
                    break;
                case 2:
                    Application.Current.UserAppTheme = OSAppTheme.Light;
                    ActualThemeLabel.Text = OSAppTheme.Light.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}