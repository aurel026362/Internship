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
    public class ExamMarkRepository : GenericRepository<ExamMark>, IExamMarkRepository
    {
        
        public ExamMarkRepository(MyAppContext context) : base(context)
        {
        }

        public ExamMark GetExamMark(long userId, long moduleId)
        {
            var result = _context.ExamMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Exam).ThenInclude(x => x.Module)
                .FirstOrDefault(x => x.Intern.UserId.Equals(userId) && x.Exam.ModuleId.Equals(moduleId));

            return result;
        }

        public IList<ExamMark> GetExamMarks()
        {
            var list = _context.ExamMarks.Include(x => x.Intern).ThenInclude(x => x.User)
                .Include(x => x.Exam).ThenInclude(x => x.Module).ToList();

            return list;
        }

        public IList<ExamMark> GetExamMarksByModuleId(long moduleId)
        {
            var list = _context.ExamMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Exam).ThenInclude(x => x.Module)
                .Where(x => x.Exam.ModuleId.Equals(moduleId)).ToList();

            return list;
        }

        public IList<ExamMark> GetExamMarksByUserId(long userId)
        {
            var list = _context.ExamMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Exam).ThenInclude(x => x.Module)
                .Where(x => x.Intern.UserId.Equals(userId)).ToList();

            return list;
        }
    }
}
