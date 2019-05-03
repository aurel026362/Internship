using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
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

        public UserDetailedDto GetUserById(long Id)
        {
            var result = _userRepository.GetUserById(Id);
            var resultDto = _mapper.Map<UserDetailedDto>(result);

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

        public IList<UserDetailedDto> GetUsersDetails()
        {
            var list = _userRepository.GetUsersDetails();
            var listDto = _mapper.Map<IList<UserDetailedDto>>(list);

            return listDto;
        }

        public IList<UserDetailedDto> GetInternsAndMenthors()
        {
            var list = _userRepository.GetInternsAndMenthors();
            var listDto = _mapper.Map<IList<UserDetailedDto>>(list);

            return listDto;
        }

        public void AddIntern(InternDto internDto)
        {
            var intern = _mapper.Map<Intern>(internDto);
            _userRepository.AddIntern(intern);
        }

        public void AddMenthor(MenthorDto menthorDto)
        {
            var menthor = _mapper.Map<Menthor>(menthorDto);
            _userRepository.AddMenthor(menthor);
        }

        public void DeleteUser(long UserId)
        {
            _userRepository.DeleteUser(UserId);
        }
    }
}
