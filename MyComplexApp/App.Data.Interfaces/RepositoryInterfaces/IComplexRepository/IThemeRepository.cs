using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IThemeRepository
    {
        IList<ComplexTheme> GetThemes();
        IList<ComplexTheme> GetThemesByModuleId(long moduleId);
        IList<ComplexTheme> GetThemesByMenthorId(long menthorId);
    }
}
