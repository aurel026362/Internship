using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Services.Dtos.DTOs.Group;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGenericRepository<Group> _groupRepository;
        private readonly IMapper _mapper;

        public GroupService(IGenericRepository<Group> groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }

        public GroupDto GetGroupById(long id)
        {
            var group = _groupRepository.GetById(id);
            var groupDto = _mapper.Map<GroupDto>(group);
            return groupDto;
        }

        public IList<GroupDto> GetGroups()
        {
            var list = _groupRepository.GetAll();
            var listDto = _mapper.Map<IList<GroupDto>>(list);
            return listDto;
        }
    }
}
