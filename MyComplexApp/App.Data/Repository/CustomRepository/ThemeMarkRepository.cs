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
    public class ThemeMarkRepository : IThemeMarkRepository
    {
        private readonly MyAppContext _context;
        private readonly DbSet<ThemeMark> DbSet;

        public ThemeMarkRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public string AddOrUpdateThemeMark(ThemeMark themeMark)
        {   
            var result="";
            var oldmark = _context.ThemeMarks.Where(x => x.ThemeId.Equals(themeMark.ThemeId) && x.InternId.Equals(themeMark.InternId)).FirstOrDefault();

            if (oldmark != null)
            {
                oldmark.Mark = themeMark.Mark;
                oldmark.Comment = themeMark.Comment;
                _context.ThemeMarks.Update(oldmark);
                result = "update";
            }
            else
            {
                _context.Add(themeMark);
                result = "add";
            }
            _context.SaveChanges();
            return result;
        }

        public IList<ThemeMark> GetMoreThemeMarks(int page, string orderby, string sorting)
        {
            throw new NotImplementedException();
        }

        public IList<ThemeMark> GetThemeMarks(long userId, long moduleId)
        {
            var list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                .Where(x => x.Intern.UserId.Equals(userId) && x.Theme.ModuleId.Equals(moduleId)).ToList();

            return list;
        }

        public IList<ThemeMark> GetThemeMarks()
        {
            var list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User)
                .Include(x => x.Theme).OrderBy(x => x.Intern.User.Email).Take(10).ToList();

            return list;
        }

        public IList<ThemeMark> GetThemeMarksByModuleId(long moduleId)
        {
            var list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                .Where(x => x.Theme.ModuleId.Equals(moduleId)).ToList();

            return list;
        }

        public IList<ThemeMark> GetThemeMarksByUserId(long userId)
        {
            var list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                .Where(x => x.Intern.UserId.Equals(userId)).ToList();

            return list;
        }

        public IList<ThemeMark> GetThemeMarksSorted(int page, string orderBy, bool sorting)
        {
            IList<ThemeMark> list = null;

            switch (orderBy)
            {
                case "themename":
                    {
                        if (sorting == true)
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderBy(x => x.Theme.Name).Skip(page * 10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderByDescending(x => x.Theme.Name).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                case "mark":
                    {
                        if (sorting == true)
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderBy(x => x.Mark).Skip(page * 10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderByDescending(x => x.Mark).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                case "email":
                    {
                        if (sorting == true)
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderBy(x => x.Intern.User.Email).Skip(page * 10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                                .OrderByDescending(x => x.Intern.User.Email).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                default: { } break;
            }
            return list;
        }

        public IList<ThemeMark> GetTMarksByEmail(string email)
        {
            IList<ThemeMark> list = null;
            if (email != null)
            {
                list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme)
                    .Where(x => x.Intern.User.Email.Contains(email)).ToList();

                return list;
            }
            else
            {
                list = GetThemeMarks();
            }

            return list;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
