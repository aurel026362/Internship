using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface ITMarkRepository
    {
        IList<ComplexTMark> GetThemeMarksByUserId(long userId);
        IList<ComplexTMark> GetThemeMarks(long userId, long moduleId);
        IList<ComplexTMark> GetThemeMarksByModuleId(long moduleId);
        IList<ComplexTMark> GetThemeMarks();
        IList<ComplexTMark> GetThemeMarksSorted(int page, string orderby, bool sorting);
        IList<ComplexTMark> GetTMarksByEmail(string email);
        double GetAvgTMarks();
        double GetAvgTMarksByUserId(long userId);
        double GetAvgTMarksByModuleId(long moduleId);
        void Save();
    }
}
