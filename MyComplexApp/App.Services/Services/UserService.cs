using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, UserManager<User> userManager, IMapper mapper)
        {
            _userRepository = userRepository;
            _userManager = userManager;
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

        public void UpdateUser(UserDetailedDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            _userRepository.UpdateUser(userEntity);
        }

        public IList<RequestedUserDto> GetRequestedUsers()
        {
            var list = _userRepository.GetRequestedUsers();
            var listDto = list.Select(x => new RequestedUserDto()
            {
                User = new UserDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    EMail = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    DateOfBirth = x.DateOfBirth
                },
                Role = x.TypeUser
            }).ToList();

            return listDto;
        }

        public void AddRequestedUser(long requestedUserId)
        {
            var requestedUser = _userRepository.GetRequestedUser(requestedUserId);

            var user = new User()
            {
                FirstName = requestedUser.FirstName,
                LastName = requestedUser.LastName,
                Email = requestedUser.Email,
                PhoneNumber = requestedUser.PhoneNumber,
                DateOfBirth = requestedUser.DateOfBirth,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0
            };
            
                try
                {
                    _userManager.CreateAsync(user, requestedUser.Password);
                    _userManager.AddToRoleAsync(user, requestedUser.TypeUser);
                    switch (requestedUser.TypeUser)
                    {
                        case "Menthor": { AddMenthor(new MenthorDto() { UserId = user.Id }); } break;
                        case "Intern": { AddIntern(new InternDto() { UserId = user.Id }); } break;
                        case "Admin": break;
                        default: throw new Exception();
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
        }

        public async Task AddUser(User user)
        {
            await _userManager.CreateAsync(user);
        }

        public void DeleteRequestedUser(long requestedUserId)
        {
            _userRepository.DeclineRequestedUser(requestedUserId);
            _userRepository.Save();
        }
    }
}
