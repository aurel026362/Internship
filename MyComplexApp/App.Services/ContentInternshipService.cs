using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.Abstractions;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.Module;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Interfaces.ContentInternshipService;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public class ContentInternshipService : IContentInternshipService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IExamRepository _examRepository;
        private readonly IThemeRepository _themeRepository;
        private readonly IGenericRepository<Module> _moduleRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;


        public ContentInternshipService(ICommentRepository commentRepository, IExamRepository examRepository, IThemeRepository themeRepository, IGenericRepository<Module> moduleRepository,
            IMapper mapper, UserManager<User> userManager)
        {
            _commentRepository = commentRepository;
            _examRepository = examRepository;
            _themeRepository = themeRepository;
            _moduleRepository = moduleRepository;
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

        public IList<ExamDto> GetExams()
        {
            var list = _examRepository.GetExams();
            var listDto = _mapper.Map<IList<ExamDto>>(list);

            return listDto;
        }

        public IList<ModuleDto> GetModules()
        {
            var list = _moduleRepository.GetAll();
            var listDto = _mapper.Map<IList<ModuleDto>>(list);

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

        public void Save()
        {
            _moduleRepository.Save();
        }
    }
}
