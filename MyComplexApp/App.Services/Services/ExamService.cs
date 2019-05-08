using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public ExamService(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public ExamDto GetExam(long moduleId)
        {
            var result = _examRepository.GetExam(moduleId);
            var resultDto = new ExamDto()
            {
                ModuleName = result.Module.Name,
                Date = result.Date
            };

            return resultDto;
        }

        public IList<ExamDto> GetExams()
        {
            var list = _examRepository.GetExams().Select(x => new ExamDto()
            {
                ModuleName = x.Module.Name,
                Date = x.Date
            }).ToList();

            return list;
        }
    }
}
