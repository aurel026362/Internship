using App.Services.Dtos.DTOs.ThemeMark;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface ITMarkService
    {
        IList<ThemeMarkDto> GetThemeMarksByUserId(long userId);
        ThemeMarkDto GetThemeMark(long userId, long themeId);
        IList<ThemeMarkDto> GetThemeMarksByThemeId(long themeId);
        IList<ThemeMarkDto> GetThemeMarks();
    }
}
