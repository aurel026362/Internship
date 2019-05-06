using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;
using App.Services.Dtos.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Interfaces.IServices
{
    public interface IUserService
    {
        UserDetailedDto GetUserById(long Id);
        IList<UserDto> GetUsers();
        IList<UserDto> GetInterns();
        IList<UserDto> GetMenthors();
        IList<UserDetailedDto> GetUsersDetails();
        IList<UserDetailedDto> GetInternsAndMenthors();
        void AddIntern(InternDto intern);
        void AddMenthor(MenthorDto menthor);
        void DeleteUser(long UserId);
        void UpdateUser(long userId, string newFName, string newLName, string nenwPhone, DateTime newdDBirth);
        void UpdateUser(UserDetailedDto user);
    }
}
