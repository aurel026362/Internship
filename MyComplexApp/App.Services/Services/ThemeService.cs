using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IThemeRepository _themeRepository;
        private readonly IMapper _mapper;

        public ThemeService(IThemeRepository themeRepository, IMapper mapper)
        {
            _themeRepository = themeRepository;
            _mapper = mapper;
        }

        public IList<ThemeDto> GetThemes()
        {
            var list = _themeRepository.GetThemes().Select(x => new ThemeDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                Source = x.Source,
                ModuleName = x.Module.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }

        public IList<ThemeDto> GetThemesByMenthorId(long menthorId)
        {
            var list = _themeRepository.GetThemesByMenthorId(menthorId).Select(x => new ThemeDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                Source = x.Source,
                ModuleName = x.Module.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }

        public IList<ThemeDto> GetThemesByModuleId(long moduleId)
        {
            var list = _themeRepository.GetThemesByModuleId(moduleId).Select(x => new ThemeDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                Source = x.Source,
                ModuleName = x.Module.Name,
                MenthorEMail = x.Menthor.User.Email
            }).ToList();

            return list;
        }
    }
}
