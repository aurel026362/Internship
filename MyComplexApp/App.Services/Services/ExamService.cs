using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
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
            var resultDto = _mapper.Map<ExamDto>(result);

            return resultDto;
        }

        public IList<ExamDto> GetExams()
        {
            var list = _examRepository.GetExams();
            var listDto = _mapper.Map<IList<ExamDto>>(list);

            return listDto;
        }
    }
}
