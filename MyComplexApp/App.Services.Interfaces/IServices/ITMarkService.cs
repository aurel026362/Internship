using App.Services.Dtos.DTOs.ThemeMark;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface ITMarkService
    {
        IList<ThemeMarkDto> GetThemeMarksByUserId(long userId);
        IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId);
        IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId);
        IList<ThemeMarkDto> GetThemeMarks();
        IList<ThemeMarkDto> GetThemeMarksSorted(int page, string orderby, bool sorting);
        IList<ThemeMarkDto> GetTMarksByEmail(string email);
        double GetAvgTMarks();
        double GetAvgTMarksByUserId(long userId);
        double GetAvgTMarksByModuleId(long moduleId);
    }
}
