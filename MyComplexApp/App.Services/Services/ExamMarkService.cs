using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class ExamMarkService : IExamMarkService
    {
        private readonly IExamMarkRepository _eMarkRepository;
        private readonly IMapper _mapper;

        public ExamMarkService(IExamMarkRepository eMarkRepository, IMapper mapper)
        {
            _eMarkRepository = eMarkRepository;
            _mapper = mapper;
        }

        public ExamMarkDto GetExamMark(long userId, long moduleId)
        {
            var result = _eMarkRepository.GetExamMark(userId, moduleId);

            var resultDto = new ExamMarkDto()
            {
                UserId = result.Intern.UserId,
                UserEmail = result.Intern.User.Email,
                ModuleName = result.Exam.Module.Name,
                Mark = result.Mark,
                Comment = result.Comment
            };

            return resultDto;
        }

        public IList<ExamMarkDto> GetExamMarks()
        {
            var list = _eMarkRepository.GetExamMarks().Select(x=> new ExamMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ExamMarkDto> GetExamMarksByModuleId(long moduleId)
        {
            var list = _eMarkRepository.GetExamMarksByModuleId(moduleId).Select(x => new ExamMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }

        public IList<ExamMarkDto> GetExamMarksByUserId(long userId)
        {
            var list = _eMarkRepository.GetExamMarksByUserId(userId).Select(x => new ExamMarkDto()
            {
                UserId = x.Intern.UserId,
                UserEmail = x.Intern.User.Email,
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return list;
        }
    }
}
