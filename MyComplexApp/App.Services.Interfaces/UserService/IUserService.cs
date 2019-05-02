using App.Services.Dtos.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Interfaces.UserService
{
    public interface IUserService : IGroupService, ISavingContext
    {
        UserDto GetUserById(long Id);
        IList<UserDto> GetUsers();
        IList<UserDto> GetInterns();
        IList<UserDto> GetMenthors();
        IList<UserDetailedDto> GetUsersDetails();
        UserDetailedDto GetUserDetails(long id);
        void UpdateUser(long userId, string newFName, string newLName, string nenwPhone, DateTime newdDBirth);
    }
}
