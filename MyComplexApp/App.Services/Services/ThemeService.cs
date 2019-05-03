using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
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
            var list = _themeRepository.GetThemes();
            var listDto = _mapper.Map<IList<ThemeDto>>(list);

            return listDto;
        }

        public IList<ThemeDto> GetThemesByMenthorId(long menthorId)
        {
            var list = _themeRepository.GetThemesByMenthorId(menthorId);
            var listDto = _mapper.Map<IList<ThemeDto>>(list);

            return listDto;
        }

        public IList<ThemeDto> GetThemesByModuleId(long moduleId)
        {
            var list = _themeRepository.GetThemesByModuleId(moduleId);
            var listDto = _mapper.Map<IList<ThemeDto>>(list);

            return listDto;
        }
    }
}
