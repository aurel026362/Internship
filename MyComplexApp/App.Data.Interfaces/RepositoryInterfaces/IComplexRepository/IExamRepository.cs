using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IExamRepository
    {
        IList<ComplexExam> GetExams();
        ComplexExam GetExam(long moduleId);
    }
}
