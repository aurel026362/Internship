using App.Services.Dtos.DTOs.Theme;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.ContentInternshipService
{
    public interface IThemeService
    {
        IList<ThemeDto> GetThemes();
        IList<ThemeDto> GetThemesByModuleId(long moduleId);
        IList<ThemeDto> GetThemesByMenthorId(long menthorId);
    }
}
