using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IUserRepository/*:IRepository<User>*/
    {
        User GetUserById(long Id);
        IList<User> GetUsers();
        IList<User> GetUsersDetails();
        User GetUserDetails(long id);
        IList<User> GetInterns();
        IList<User> GetMenthors();
        void UpdateUser(long userId, string newFName, string newLName, string nenwPhone, DateTime newdDBirth);
        void Save();
    }
}
