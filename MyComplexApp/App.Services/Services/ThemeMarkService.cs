using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class ThemeMarkService : ITMarkService
    {
        private readonly IThemeMarkRepository _themeMarkRepository;
        private readonly IMapper _mapper;

        public ThemeMarkService(IThemeMarkRepository tMarkRepository, IMapper mapper)
        {
            _themeMarkRepository = tMarkRepository;
            _mapper = mapper;
        }

        public string AddOrUpdateThemeMark(AddThemeMarkDto themeMark)
        {
            var mark = _mapper.Map<ThemeMark>(themeMark);
            var result = _themeMarkRepository.AddOrUpdateThemeMark(mark);
            return result;
        }

        public IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId)
        {
            var list = _themeMarkRepository.GetThemeMarks(userId, moduleId).Select(x=> new ThemeMarkDto()
            {
                UserId=x.Intern.UserId,
                UserEmail= x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ThemeMarkDto> GetThemeMarks()
        {
            var list = _themeMarkRepository.GetThemeMarks().Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId)
        {
            var list = _themeMarkRepository.GetThemeMarksByModuleId(moduleId).Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ThemeMarkDto> GetThemeMarksByUserId(long userId)
        {
            var list = _themeMarkRepository.GetThemeMarksByUserId(userId).Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ThemeMarkDto> GetThemeMarksSorted(int page, string orderBy, bool sorting)
        {
            var list = _themeMarkRepository.GetThemeMarksSorted(page, orderBy, sorting).Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ThemeMarkDto> GetTMarksByEmail(string email)
        {
            var list = _themeMarkRepository.GetTMarksByEmail(email).Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ThemeName = x.Theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }
    }
}
