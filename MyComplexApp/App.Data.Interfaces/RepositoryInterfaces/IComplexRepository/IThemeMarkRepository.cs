using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IThemeMarkRepository
    {
        IList<ThemeMark> GetThemeMarksByUserId(long userId);
        IList<ThemeMark> GetThemeMarks(long userId, long moduleId);
        IList<ThemeMark> GetThemeMarksByModuleId(long moduleId);
        IList<ThemeMark> GetThemeMarks();
        IList<ThemeMark> GetThemeMarksSorted(int page, string orderby, bool sorting);
        IList<ThemeMark> GetTMarksByEmail(string email);
        string AddOrUpdateThemeMark(ThemeMark themeMark);
        void Save();
    }
}
