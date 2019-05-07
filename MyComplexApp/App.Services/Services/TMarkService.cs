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
    public class TMarkService : ITMarkService
    {
        private readonly ITMarkRepository _tMarkRepository;
        private readonly IMapper _mapper;

        public TMarkService(ITMarkRepository tMarkRepository, IMapper mapper)
        {
            _tMarkRepository = tMarkRepository;
            _mapper = mapper;
        }
        
        public double GetAvgTMarks()
        {
            var marks = _tMarkRepository.GetThemeMarks();
            double result = 0;

            if ((marks != null) & (marks.Any()))
            {
                result = marks.Average(x => x.Mark);
            }

            return result;
        }

        public double GetAvgTMarksByModuleId(long moduleId)
        {
            var marks = _tMarkRepository.GetThemeMarksByModuleId(moduleId);
            double result = 0;

            if ((marks != null) & (marks.Any()))
            {
                result = marks.Average(x => x.Mark);
            }

            return result;
        }

        public double GetAvgTMarksByUserId(long userId)
        {
            var marks = _tMarkRepository.GetThemeMarksByUserId(userId);
            double result = 0;

            if ((marks != null) & (marks.Any()))
            {
                result = marks.Average(x => x.Mark);
            }

            return result;
        }

        public IList<ThemeMarkDto> GetThemeMarks(long userId, long moduleId)
        {
            var list = _tMarkRepository.GetThemeMarks(userId, moduleId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarks()
        {
            var list = _tMarkRepository.GetThemeMarks();
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksByModuleId(long moduleId)
        {
            var list = _tMarkRepository.GetThemeMarksByModuleId(moduleId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksByUserId(long userId)
        {
            var list = _tMarkRepository.GetThemeMarksByUserId(userId);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetThemeMarksSorted(int page, string orderBy, bool sorting)
        {
            var list = _tMarkRepository.GetThemeMarksSorted(page, orderBy, sorting);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }

        public IList<ThemeMarkDto> GetTMarksByEmail(string email)
        {
            var list = _tMarkRepository.GetTMarksByEmail(email);
            var listDto = _mapper.Map<IList<ThemeMarkDto>>(list);

            return listDto;
        }
    }
}
