using App.Services.Dtos.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetById(long Id);
    }
}
