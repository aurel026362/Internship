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
    public class InternAchievements: IInternAchievements
    {
        //private readonly IRepository<Module> _moduleRepository;
        //private readonly IRepository<Group> _groupRepoitory;

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
            //IRepository<Module> moduleRepository,
            //IRepository<Group> groupRepoitory,

            IMapper mapper, 
            UserManager<User> userManager)
        {
            _commentRepository = commentRepository;
            _examMarkRepository = examMarkRepository;
            _examRepository = examRepository;
            _themeRepository = themeRepository;
            _TMarkRepository = TMarkRepository;
            _userRepository = userRepository;
            //_moduleRepository = moduleRepository;
            //_groupRepoitory = groupRepoitory;

            _userManager = userManager;
            _mapper = mapper;
        }

        public void AddComment(CommentDto comment)
        {
            //var com = _mapper.Map<ComplexComment>(comment);
            //_commentRepository.AddComment(com);
        }

        public void AddComment(long userId, long themeId, string content)
        {
            _commentRepository.AddComment(userId, themeId, content);
        }

        public IList<CommentDto> GetComments()
        {
            var list = _commentRepository.GetComments();
            var listDto = _mapper.Map<IList<CommentDto>>(list);

            return listDto;
        }

        public IList<CommentDto> GetComments(long themeId)
        {
            var list = _commentRepository.GetComments(themeId);
            var listDto = _mapper.Map<IList<CommentDto>>(list);

            return listDto;
        }

        public IList<CommentDto> GetComments(int page, long themeId)
        {
            var list = _commentRepository.GetComments(page, themeId);
            var listDto = _mapper.Map<IList<CommentDto>>(list);

            return listDto;
        }

        public ExamDto GetExam(long moduleId)
        {
            var result = _examRepository.GetExam(moduleId);
            var resultDto = _mapper.Map<ExamDto>(result);

            return resultDto;
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

        public IList<ExamDto> GetExams()
        {
            var list = _examRepository.GetExams();
            var listDto = _mapper.Map<IList<ExamDto>>(list);

            return listDto;
        }

        public IList<GroupDto> GetGroups()
        {
            //var list = _groupRepoitory.GetAll();
            //var listDto = _mapper.Map<IList<GroupDto>>(list);
            return null;
            //return listDto;
        }

        public IList<UserDto> GetInterns()
        {
            var list = _userRepository.GetInterns();
            var listDto = _mapper.Map<IList<UserDto>>(list);

            return listDto;
        }

        public IList<UserDto> GetMenthors()
        {
            var list = _userRepository.GetMenthors();
            var listDto = _mapper.Map<IList<UserDto>>(list);

            return listDto;
        }

        public IList<ModuleDto> GetModules()
        {
            //var list = _moduleRepository.GetAll();
            //var listDto = _mapper.Map<IList<ModuleDto>>(list);

            //return listDto;
            return null;
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

        public UserDto GetUserById(long Id)
        {
            var result = _userRepository.GetUserById(Id);
            var resultDto = _mapper.Map<UserDto>(result);

            return resultDto;
        }

        public IList<UserDto> GetUsers()
        {
            var list = _userRepository.GetUsers();
            var listDto = _mapper.Map<IList<UserDto>>(list);

            return listDto;
        }

        public void UpdateUser(long userId, string newFName, string newLName, string newPhone, DateTime newdDBirth)
        {
            _userRepository.UpdateUser(userId, newFName, newLName, newPhone, newdDBirth);
        }
    }
}
