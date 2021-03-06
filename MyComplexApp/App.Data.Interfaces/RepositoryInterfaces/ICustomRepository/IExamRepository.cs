﻿using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IExamRepository : IGenericRepository<Exam>
    {
        IList<Exam> GetExams();
        Exam GetExam(long moduleId);
    }
}
