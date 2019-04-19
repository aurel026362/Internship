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

        public ComplexTMark GetThemeMark(long userId, long themeId)
        {
            var result = DbSet.Where(x => x.Intern.UserId.Equals(userId) && x.ThemeId.Equals(themeId))
                .Select(x => new ComplexTMark
                {
                    UserEmail = x.Intern.User.Email,
                    ThemeName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).FirstOrDefault();

            return result;
        }

        public IList<ComplexTMark> GetThemeMarks()
        {
            var list = DbSet.Select(x => new ComplexTMark()
            {
                UserEmail = x.Intern.User.Email,
                ThemeName = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ComplexTMark> GetThemeMarksByThemeId(long themeId)
        {
            var list = DbSet.Where(x => x.ThemeId.Equals(themeId))
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
            var list = DbSet.Where(x => x.Intern.UserId.Equals(userId))
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
