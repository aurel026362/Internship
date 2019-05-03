using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class EMarkService : IEMarkService
    {
        private readonly IEMarkRepository _eMarkRepository;
        private readonly IMapper _mapper;

        public EMarkService(IEMarkRepository eMarkRepository, IMapper mapper)
        {
            _eMarkRepository = eMarkRepository;
            _mapper = mapper;
        }

        public ExamMarkDto GetExamMark(long userId, long moduleId)
        {
            var result = _eMarkRepository.GetExamMark(userId, moduleId);
            var resultDto = _mapper.Map<ExamMarkDto>(result);

            return resultDto;
        }

        public IList<ExamMarkDto> GetExamMarks()
        {
            var list = _eMarkRepository.GetExamMarks();
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }

        public IList<ExamMarkDto> GetExamMarksByModuleId(long moduleId)
        {
            var list = _eMarkRepository.GetExamMarksByModuleId(moduleId);
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }

        public IList<ExamMarkDto> GetExamMarksByUserId(long userId)
        {
            var list = _eMarkRepository.GetExamMarksByUserId(userId);
            var listDto = _mapper.Map<IList<ExamMarkDto>>(list);

            return listDto;
        }
    }
}
