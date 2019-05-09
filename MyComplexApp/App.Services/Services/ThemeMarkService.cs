using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class ThemeMarkService : IThemeMarkService
    {
        private readonly IThemeMarkRepository _themeMarkRepository;
        private readonly IThemeRepository _themeRepository;
        private readonly IMapper _mapper;

        public ThemeMarkService(IThemeMarkRepository themeMarkRepository, IThemeRepository themeRepository, IMapper mapper)
        {
            _themeMarkRepository = themeMarkRepository;
            _themeRepository = themeRepository;
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
            var list = _themeMarkRepository.GetThemeMarks(userId, moduleId).Select(x => new ThemeMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
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

        public IList<ThemeMarkDto> GetThemeMarksByEmail(string email)
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

        public IList<string> GetBadThemeMarks(long userId)
        {
            var list = _themeMarkRepository.GetThemeMarksByUserId(userId).Where(x => x.Mark < 8)
                .OrderBy(x => x.Mark).Take(5).Select(x=>x.Theme.Name).ToList();

            return list;
        }

        public IList<HardThemeDto> GetBadThemeMarks()
        {
            IList<HardThemeDto> badThemes = new List<HardThemeDto>();

            var themes = _themeRepository.GetThemes();

            var themesDto = themes.Select(x => new ThemeDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                Source = x.Source,
                MenthorEMail = x.Menthor.User.Email,
                ModuleName = x.Module.Name
            }).ToList();

            foreach (var item in themesDto)
            {
                var marks = _themeMarkRepository.GetAllThemeMarks().Where(x =>x.ThemeId.Equals(item.Id)).ToList();
                var avgMarks = 0.0;

                if (marks.Any())
                {
                    avgMarks = marks.Average(x => x.Mark);

                    if (avgMarks < 7.5 && avgMarks > 0.0)
                    {
                        badThemes.Add(new HardThemeDto()
                        {
                            Theme = item,
                            AvgMark = avgMarks
                        });
                    }
                }
            }
            return badThemes;
        }

        public IList<ThemeMarkDto> GetThemeMarkByThemeId(long themeId)
        {
            var list = _themeMarkRepository.GetThemeMarkByThemeId(themeId)
                .Select(x => new ThemeMarkDto()
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
