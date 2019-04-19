using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IEMarkRepository
    {
        IList<ComplexEMark> GetExamMarksByUserId(long userId);
        ComplexEMark GetExamMark(long userId, long moduleId);
        IList<ComplexEMark> GetExamMarksByModuleId(long moduleId);
        IList<ComplexEMark> GetExamMarks();
    }
}
