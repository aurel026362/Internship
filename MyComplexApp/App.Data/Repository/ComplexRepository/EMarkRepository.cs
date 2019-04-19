using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.Abstractions;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepositorty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Data.Repository.ComplexRepository
{
    public class EMarkRepository : IEMarkRepository
    {
        private readonly MyAppContext _context;
        private readonly DbSet<ExamMark> DbSet;

        public EMarkRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public ComplexEMark GetExamMark(long userId, long moduleId)
        {
            var result = DbSet.Where(x => x.Intern.UserId.Equals(userId) && x.Exam.ModuleId.Equals(moduleId))
                .Select(x => new ComplexEMark()
                {
                    UserEmail = x.Intern.User.Email,
                    ModuleName = x.Exam.Module.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).FirstOrDefault();

            return result;
        }

        public IList<ComplexEMark> GetExamMarks()
        {
            var list = DbSet.Select(x => new ComplexEMark()
            {
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ComplexEMark> GetExamMarksByModuleId(long moduleId)
        {
            var list = DbSet.Where(x=>x.Exam.ModuleId.Equals(moduleId)).Select(x => new ComplexEMark()
            {
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ComplexEMark> GetExamMarksByUserId(long userId)
        {
            var list = DbSet.Where(x => x.Intern.UserId.Equals(userId)).Select(x => new ComplexEMark()
            {
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
