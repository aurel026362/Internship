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
    public class ExamRepository : IExamRepository
    {
        private readonly MyAppContext _context;
        private readonly DbSet<Exam> DbSet;

        public ExamRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public Exam GetExam(long moduleId)
        {
            var result = _context.Exams.Include(x=>x.Module).Where(x => x.ModuleId.Equals(moduleId)).FirstOrDefault();

            return result;
        }

        public IList<Exam> GetExams()
        {
            var list = _context.Exams.Include(x=>x.Module).ToList();

            return list;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
