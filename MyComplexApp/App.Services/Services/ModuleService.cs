using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Services.Dtos.DTOs.Module;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IGenericRepository<Module> _moduleRepository;
        private readonly IMapper _mapper;

        public ModuleService(IGenericRepository<Module> moduleRepository, IMapper mapper)
        {
            _moduleRepository = moduleRepository;
            _mapper = mapper;
        }

        public IList<ModuleDto> GetModules()
        {
            var list = _moduleRepository.GetAll();
            var listDto = _mapper.Map<IList<ModuleDto>>(list);

            return listDto;
        }
    }
}
