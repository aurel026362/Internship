//using App.Data.Domain.DomainModels.Concrete;
//using App.Data.Domain.DomainModels.Identity;
//using App.Data.Interfaces.Abstractions;
//using App.Data.Interfaces.RepositoryInterfaces;
//using App.Data.Interfaces.RepositoryInterfaces.IComplexRepositorty;
//using App.Services.Dtos.DTOs.Exam;
//using App.Services.Dtos.DTOs.ExamMark;
//using App.Services.Dtos.DTOs.Group;
//using App.Services.Dtos.DTOs.Module;
//using App.Services.Dtos.DTOs.Theme;
//using App.Services.Dtos.DTOs.ThemeMark;
//using App.Services.Dtos.DTOs.User;
//using App.Services.Interfaces;
//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.Abstractions;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Dtos.DTOs.Group;
using App.Services.Dtos.DTOs.Module;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public class InternAchievements : IInternAchievements
    {
        private readonly IEMarkRepository _examMarkRepository;
        private readonly ITMarkRepository _TMarkRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public InternAchievements(IEMarkRepository examMarkRepository, ITMarkRepository TMarkRepository, IMapper mapper, UserManager<User> userManager)
        {
            _examMarkRepository = examMarkRepository;
            _TMarkRepository = TMarkRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public ExamMarkDto GetExamMark(long userId, long moduleId)
        {
            var result = _examMarkRepository.GetExamMark(userId, moduleId);
            var resultDto = _mapper.Map<ExamMarkDto>(result);

            return resultDto;
        }

        public IList<ExamMarkDto> GetExamMarks()
        {
            var list = _examMarkRepository.GetExamMarks();
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }

        public IList<ExamMarkDto> GetExamMarksByModuleId(long moduleId)
        {
            var list = _examMarkRepository.GetExamMarksByModuleId(moduleId);
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }

        public IList<ExamMarkDto> GetExamMarksByUserId(long userId)
        {
            var list = _examMarkRepository.GetExamMarksByUserId(userId);
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId)
        {
            var list = _TMarkRepository.GetThemeMarks(userId, moduleId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarks()
        {
            var list = _TMarkRepository.GetThemeMarks();
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId)
        {
            var list = _TMarkRepository.GetThemeMarksByModuleId(moduleId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksByUserId(long userId)
        {
            var list = _TMarkRepository.GetThemeMarksByUserId(userId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksSorted(string orderBy, string sorting)
        {
            var list = _TMarkRepository.GetThemeMarksSorted(orderBy, sorting);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public void Save()
        {
            _TMarkRepository.Save();
        }
    }
}
