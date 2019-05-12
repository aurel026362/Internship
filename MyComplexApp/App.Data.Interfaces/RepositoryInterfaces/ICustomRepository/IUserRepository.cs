using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IUserRepository:IGenericRepository<User>
    {
        User GetUserById(long Id);
        IList<User> GetUsers();
        IList<User> GetInterns();
        IList<User> GetMenthors();
        IList<User> GetInternsAndMenthors();
        IList<User> GetRequestedUsers();
        void UpdateUser(long userId, string newFName, string newLName, string nenwPhone, DateTime newdDBirth);
        void UpdateUser(User user);
        void AddIntern(Intern intern);
        void AddMenthor(Menthor menthor);
        void DeleteUser(long userId);
        void Save();
    }
}
