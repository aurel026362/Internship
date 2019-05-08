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
    public class ThemeRepository : IThemeRepository
    {
        private readonly MyAppContext _context;

        public ThemeRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public IList<Theme> GetThemes()
        {
            var list = _context.Themes.Include(x=>x.Module).Include(x=>x.Menthor).ThenInclude(x=>x.User)
                .ToList();

            return list;
        }

        public IList<Theme> GetThemesByMenthorId(long menthorId)
        {
            var list = _context.Themes.Include(x => x.Module).Include(x => x.Menthor).ThenInclude(x => x.User)
                .Where(x=>x.MenthorId.Equals(menthorId)).ToList();

            return list;
        }

        public IList<Theme> GetThemesByModuleId(long moduleId)
        {
            var list = _context.Themes.Include(x => x.Module).Include(x => x.Menthor).ThenInclude(x => x.User)
                .Where(x=>x.ModuleId.Equals(moduleId)).ToList();

            return list;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
