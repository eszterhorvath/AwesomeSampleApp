using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace SampleApp.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private Theme _theme = Theme.System;
        private Dictionary<string, Theme> _favoriteThemeAnswers;
        private List<string> _keysList;
        private MvxCommand<string> _selectFavoriteThemeCommand;

        public StartViewModel()
        {
            FavoriteThemeAnswers = new Dictionary<string, Theme>
            {
                { "Be smart and figure this out from my system theme.", Theme.System },
                { "Dark theme is the best theme.", Theme.Dark },
                { "My favorite theme is light theme because i'm a boomer.", Theme.Light }
            };

            SelectFavoriteThemeCommand = new MvxCommand<string>((t) => Theme = FavoriteThemeAnswers[t], _ => true);
            KeysList = FavoriteThemeAnswers.Keys.ToList();
        }

        public Theme Theme
        {
            get => _theme;
            set => this.RaiseAndSetIfChanged(ref _theme, value);
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

        public MvxCommand<string> SelectFavoriteThemeCommand
        {
            get => _selectFavoriteThemeCommand;
            set => this.RaiseAndSetIfChanged(ref _selectFavoriteThemeCommand, value);
        }

    }

    public enum Theme {System, Light, Dark}
}
