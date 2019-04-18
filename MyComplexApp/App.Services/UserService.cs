using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces;
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
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserDto> GetById(long Id)
        {
            var user = await _userRepository.GetById(Id);
            UserDto userMapped = _mapper.Map<UserDto>(user);
            return userMapped;
        }
    }
}
