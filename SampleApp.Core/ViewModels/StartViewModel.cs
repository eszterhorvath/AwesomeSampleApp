using System.Collections.Generic;
using System.Linq;
using MvvmCross.ViewModels;

namespace SampleApp.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private Dictionary<string, Theme> _favoriteThemeAnswers;
        private List<string> _keysList;

        public StartViewModel()
        {
            FavoriteThemeAnswers = new Dictionary<string, Theme>
            {
                { "Be smart and figure this out from my system theme.", Theme.System },
                { "Dark theme is the best theme.", Theme.Dark },
                { "My favorite theme is light theme because i'm a boomer.", Theme.Light }
            };
            KeysList = FavoriteThemeAnswers.Keys.ToList();
        }

        public Dictionary<string, Theme> FavoriteThemeAnswers
        {
            get => _favoriteThemeAnswers;
            set => this.RaiseAndSetIfChanged(ref _favoriteThemeAnswers, value);
        }

        public List<string> KeysList
        {
            get => _keysList;
            set => this.RaiseAndSetIfChanged(ref _keysList, value);
        }

    }
    public enum Theme { System, Light, Dark }
}
