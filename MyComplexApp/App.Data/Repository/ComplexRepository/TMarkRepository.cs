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

        public double GetAvgTMarks()
        {
            var result = _context.ThemeMarks.Average(x => x.Mark);
            return result;
        }

        public double GetAvgTMarksByModuleId(long moduleId)
        {
            var result = _context.ThemeMarks.Where(x=>x.theme.ModuleId.Equals(moduleId)).Average(x => x.Mark);
            return result;
        }

        public double GetAvgTMarksByUserId(long userId)
        {
            var result = _context.ThemeMarks.Where(x=>x.Intern.UserId.Equals(userId)).Average(x => x.Mark);
            return result;
        }

        public IList<ComplexTMark> GetMoreThemeMarks(int page, string orderby, string sorting)
        {
            throw new NotImplementedException();
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
            }).OrderBy(x=>x.UserEmail).Take(10).ToList();

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

        public IList<ComplexTMark> GetThemeMarksSorted(int page, string orderBy, bool sorting)
        {
            IList<ComplexTMark> list = null;

            switch (orderBy)
            {
                case "theme":
                    {
                        if (sorting==true)
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderBy(x => x.ThemeName).Skip(page*10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderByDescending(x => x.ThemeName).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                case "mark":
                    {
                        if (sorting == true)
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderBy(x => x.Mark).Skip(page * 10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderByDescending(x => x.Mark).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                case "email":
                    {
                        if (sorting == true)
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderBy(x => x.UserEmail).Skip(page * 10).Take(10).ToList();
                        }
                        else
                        {
                            list = _context.ThemeMarks.Select(x => new ComplexTMark()
                            {
                                UserEmail = x.Intern.User.Email,
                                ThemeName = x.theme.Name,
                                Mark = x.Mark,
                                Comment = x.Comment
                            }).OrderByDescending(x => x.UserEmail).Skip(page * 10).Take(10).ToList();
                        }
                    }
                    break;
                default: { } break;
            }
            return list;
        }

        public IList<ComplexTMark> GetTMarksByEmail(string email)
        {
            IList<ComplexTMark> list = null;
            if (email != null)
            {
                list = _context.ThemeMarks.Where(x => x.Intern.User.Email.Contains(email)).Select(x => new ComplexTMark()
                {
                    UserEmail = x.Intern.User.Email,
                    ThemeName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).ToList();

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
