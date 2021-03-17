using System;
using System.Collections.Generic;
using System.Text;
using SampleApp.Core.ViewModels;

namespace SampleApp.Core.Services
{
    public interface INativeThemeService
    {
        Theme GetSystemTheme();
    }
}
