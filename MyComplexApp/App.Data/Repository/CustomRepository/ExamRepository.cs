using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Data.Repository.ComplexRepository
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {

        public ExamRepository(MyAppContext context) : base(context)
        {
        }

        public Exam GetExam(long moduleId)
        {
            var result = _context.Exams.Include(x=>x.Module).FirstOrDefault(x => x.ModuleId.Equals(moduleId));

            return result;
        }

        public IList<Exam> GetExams()
        {
            var list = _context.Exams.Include(x=>x.Module).ToList();

            return list;
        }
    }
}
