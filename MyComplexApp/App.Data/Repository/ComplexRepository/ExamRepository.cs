using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.Abstractions;
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

        public ComplexExam GetExam(long moduleId)
        {
            var result = _context.Exams.Include(x=>x.Module).Where(x => x.ModuleId.Equals(moduleId))
                .Select(x => new ComplexExam()
                {
                    ModuleName = x.Module.Name,
                    Date = x.Date
                }).FirstOrDefault();

            return result;
        }

        public IList<ComplexExam> GetExams()
        {
            var list = _context.Exams.Include(x=>x.Module).Select(x => new ComplexExam()
            {
                ModuleName = x.Module.Name,
                Date = x.Date
            }).ToList();

            return list;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
