using App.Services.Dtos.DTOs.Theme;
using App.Services.Dtos.DTOs.ThemeMark;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface IThemeMarkService
    {
        IList<ThemeMarkDto> GetThemeMarksByUserId(long userId);
        IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId);
        IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId);
        IList<ThemeMarkDto> GetThemeMarkByThemeId(long themeId);
        IList<ThemeMarkDto> GetThemeMarks();
        IList<ThemeMarkDto> GetThemeMarksSorted(int page, string orderby, bool sorting);
        IList<ThemeMarkDto> GetThemeMarksByEmail(string email);
        IList<HardThemeDto> GetBadThemeMarks();
        IList<string> GetBadThemeMarks(long userId);
        string AddOrUpdateThemeMark(AddThemeMarkDto themeMark);
    }
}
