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
    public class ThemeMarkRepository : GenericRepository<ThemeMark>, IThemeMarkRepository
    {

        public ThemeMarkRepository(MyAppContext context):base(context)
        {
        }

        public string AddOrUpdateThemeMark(ThemeMark themeMark)
        {   
            var result="";
            var oldmark = _context.ThemeMarks.FirstOrDefault(x => x.ThemeId.Equals(themeMark.ThemeId) && x.InternId.Equals(themeMark.InternId));

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

        public IList<ThemeMark> GetAllThemeMarks()
        {
            var list = _context.ThemeMarks.ToList();
            return list;
        }

        public IList<ThemeMark> GetThemeMarkByThemeId(long themeId)
        {
            var list = _context.ThemeMarks.Where(x => x.ThemeId.Equals(themeId)).ToList();
            return list; 
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
                .Include(x => x.Theme).OrderBy(x => x.Intern.User.Email).TakeNext10();

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
            IList<ThemeMark> marks = null;

            var list = _context.ThemeMarks.Include(x => x.Intern).ThenInclude(x => x.User).Include(x => x.Theme);

            switch (orderBy)
            {
                case "themename":
                    {
                        if (sorting)
                        {
                            marks = list.OrderBy(x => x.Theme.Name).SkipTakeNext10(page);
                        }
                        else
                        {
                            marks = list.OrderByDescending(x => x.Theme.Name).SkipTakeNext10(page);
                        }
                    }
                    break;
                case "mark":
                    {
                        if (sorting)
                        {
                            marks = list.OrderBy(x => x.Mark).SkipTakeNext10(page);
                        }
                        else
                        {
                            marks = list.OrderByDescending(x => x.Mark).SkipTakeNext10(page);
                        }
                    }
                    break;
                case "email":
                    {
                        if (sorting)
                        {
                            marks = list.OrderBy(x => x.Intern.User.Email).SkipTakeNext10(page);
                        }
                        else
                        {
                            marks = list.OrderByDescending(x => x.Intern.User.Email).SkipTakeNext10(page);
                        }
                    }
                    break;
                default: { } break;
            }
            return marks;
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
