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
    public class ThemeRepository : IThemeRepository
    {
        private readonly MyAppContext _context;
        private readonly DbSet<Theme> DbSet;

        public ThemeRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public IList<ComplexTheme> GetThemes()
        {
            var list = _context.Themes.Select(x => new ComplexTheme()
            {
                Id = x.Id,
                Name = x.Name,
                TimeOfTheme = x.TimeOfTheme,
                Source = x.Source,
                ModuleName = x.Modulep.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }

        public IList<ComplexTheme> GetThemesByMenthorId(long menthorId)
        {
            var list = _context.Themes.Where(x=>x.MenthorId.Equals(menthorId)).Select(x => new ComplexTheme()
            {
                Id = x.Id,
                Name = x.Name,
                TimeOfTheme = x.TimeOfTheme,
                Source = x.Source,
                ModuleName = x.Modulep.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }

        public IList<ComplexTheme> GetThemesByModuleId(long moduleId)
        {
            var list = _context.Themes.Where(x=>x.ModuleId.Equals(moduleId)).Select(x => new ComplexTheme()
            {
                Id = x.Id,
                Name = x.Name,
                TimeOfTheme = x.TimeOfTheme,
                Source = x.Source,
                ModuleName = x.Modulep.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
