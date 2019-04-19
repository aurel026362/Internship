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
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Interfaces;
using System.Text;

namespace App.Services
{
    public class InternAchievements: IInternAchievements
    {
        private readonly IRepository<Module> _moduleRepository;
        private readonly IRepository<Group> _groupRepoitory;

        //private readonly IRepository<User> _userRepository;
        //private readonly IRepository<ComplexTheme> _themeRepository;
        //private readonly IRepository<ComplexExam> _examRepository;
        //private readonly IRepository<ComplexTMark> _themeMarkRepository;
        //private readonly IRepository<ComplexEMark> _examMarkRepository;
        //private readonly IRepository<ComplexComment> _commentRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IEMarkRepository _examMarkRepository;
        private readonly IExamRepository _examRepository;
        private readonly IThemeRepository _themeRepository;
        private readonly ITMarkRepository _TMarkRepository;
        private readonly IUserRepository _userRepository;


        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
       

        public InternAchievements(
            ICommentRepository commentRepository,
        IEMarkRepository examMarkRepository,
        IExamRepository examRepository,
        IThemeRepository themeRepository,
        ITMarkRepository TMarkRepository,
        IUserRepository userRepository,
        IMapper mapper, 
            UserManager<User> userManager)
        {

            _userManager = userManager;
            _mapper = mapper;
        }

        public ExamDto GetExam(long moduleId)
        {
            throw new NotImplementedException();
        }

        public ExamMarkDto GetExamMark(long userId, long moduleId)
        {
            throw new NotImplementedException();
        }

        public IList<ExamMarkDto> GetExamMarks()
        {
            //-------------------------------------------throw new Exception..
            var list = _examMarkRepository.GetAll();
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);
            return listDto;
        }

        public IList<ExamMarkDto> GetExamMarksByModuleId(long moduleId)
        {
            throw new NotImplementedException();
        }

        public IList<ExamMarkDto> GetExamMarksByUserId(long userId)
        {
            throw new NotImplementedException();
        }

        public IList<ExamDto> GetExams()
        {
            throw new NotImplementedException();
        }

        public IList<GroupDto> GetGroups()
        {
            var list = _groupRepoitory.GetAll();
            var listDto = _mapper.Map<IList<GroupDto>>(list);
            return listDto;
        }

        public IList<UserDto> GetInterns()
        {
            var list = _userRepository.GetAll();
        }

        public IList<UserDto> GetMenthors()
        {
            throw new NotImplementedException();
        }

        public IList<ModuleDto> GetModules()
        {
            var list = _moduleRepository.GetAll();
            var listDto = _mapper.Map<IList<ModuleDto>>(list);
            return listDto;
        }

        public ThemeMarkDto GetThemeMark(long userId, long themeId)
        {
            throw new NotImplementedException();
        }

        public IList<ThemeMarkDto> GetThemeMarks()
        {
            throw new NotImplementedException();
        }

        public IList<ThemeMarkDto> GetThemeMarksByThemeId(long themeId)
        {
            throw new NotImplementedException();
        }

        public IList<ThemeMarkDto> GetThemeMarksByUserId(long userId)
        {
            throw new NotImplementedException();
        }

        public IList<ThemeDto> GetThemes()
        {
            throw new NotImplementedException();
        }

        public IList<ThemeDto> GetThemesByMenthorId(long menthorId)
        {
            throw new NotImplementedException();
        }

        public IList<ThemeDto> GetThemesByModuleId(long moduleId)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(long Id)
        {
            throw new NotImplementedException();
        }

        public IList<UserDto> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
