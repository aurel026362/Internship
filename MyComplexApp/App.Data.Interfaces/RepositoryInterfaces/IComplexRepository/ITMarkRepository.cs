using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface ITMarkRepository
    {
        IList<ComplexTMark> GetThemeMarksByUserId(long userId);
        ComplexTMark GetThemeMark(long userId, long themeId);
        IList<ComplexTMark> GetThemeMarksByThemeId(long themeId);
        IList<ComplexTMark> GetThemeMarks();
    }
}
