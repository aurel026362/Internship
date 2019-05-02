using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Group;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces;
using App.Services.Interfaces.UserService;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IGenericRepository<Group> _groupRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(IUserRepository userRepository, IGenericRepository<Group> groupRepository, IMapper mapper, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _groupRepository = groupRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IList<GroupDto> GetGroups()
        {
            var list = _groupRepository.GetAll();
            var listDto = _mapper.Map<IList<GroupDto>>(list);
            return listDto;
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

        public UserDto GetById(long id)
        {
            var user = _userRepository.GetUserById(id);
            UserDto userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public GroupDto GetGroupById(long id)
        {
            var group = _groupRepository.GetById(id);
            var groupDto = _mapper.Map<GroupDto>(group);
            return groupDto;
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

        public void Save()
        {
            _userRepository.Save();
        }

        public IList<UserDetailedDto> GetUsersDetails()
        {
            var list = _userRepository.GetUsersDetails();
            var listDto = _mapper.Map<IList<UserDetailedDto>>(list);

            return listDto;
        }

        public UserDetailedDto GetUserDetails(long id)
        {
            var user = _userRepository.GetUserDetails(id);
            var userDto = _mapper.Map<UserDetailedDto>(user);

            return userDto;
        }
    }
}
