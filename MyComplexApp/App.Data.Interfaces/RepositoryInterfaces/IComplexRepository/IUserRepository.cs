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
        IList<User> GetInterns();
        IList<User> GetMenthors();
    }
}
