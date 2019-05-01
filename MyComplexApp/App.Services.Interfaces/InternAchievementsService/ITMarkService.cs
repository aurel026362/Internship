using App.Services.Dtos.DTOs.ThemeMark;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface ITMarkService
    {
        IList<ThemeMarkDto> GetThemeMarksByUserId(long userId);
        IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId);
        IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId);
        IList<ThemeMarkDto> GetThemeMarks();
        IList<ThemeMarkDto> GetThemeMarksSorted(string orderBy, string sorting);
        IList<ThemeMarkDto> GetMoreThemeMarks(int page, string orderby, string sorting);
    }
}
