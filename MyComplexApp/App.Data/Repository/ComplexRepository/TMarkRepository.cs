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
    public class TMarkRepository : ITMarkRepository
    {
        private readonly MyAppContext _context;
        private readonly DbSet<ThemeMark> DbSet;

        public TMarkRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public IList<ComplexTMark> GetThemeMarks(long userId, long moduleId)
        {
            var list = _context.ThemeMarks.Where(x => x.Intern.UserId.Equals(userId) && x.theme.ModuleId.Equals(moduleId))
                .Select(x => new ComplexTMark
                {
                    UserEmail = x.Intern.User.Email,
                    ThemeName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).ToList();

            return list;
        }

        public IList<ComplexTMark> GetThemeMarks()
        {
            var list = _context.ThemeMarks.Select(x => new ComplexTMark()
            {
                UserEmail = x.Intern.User.Email,
                ThemeName = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ComplexTMark> GetThemeMarksByModuleId(long moduleId)
        {
            var list = _context.ThemeMarks.Where(x => x.theme.ModuleId.Equals(moduleId))
                .Select(x => new ComplexTMark()
                {
                    UserEmail = x.Intern.User.Email,
                    ThemeName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).ToList();

            return list;
        }

        public IList<ComplexTMark> GetThemeMarksByUserId(long userId)
        {
            var list = _context.ThemeMarks.Where(x => x.Intern.UserId.Equals(userId))
                .Select(x => new ComplexTMark()
                {
                    UserEmail = x.Intern.User.Email,
                    ThemeName = x.theme.Name,
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
