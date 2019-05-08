using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IExamMarkRepository
    {
        IList<ExamMark> GetExamMarksByUserId(long userId);
        ExamMark GetExamMark(long userId, long moduleId);
        IList<ExamMark> GetExamMarksByModuleId(long moduleId);
        IList<ExamMark> GetExamMarks();
    }
}
