using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces
{
    public interface IUserRepository
    {
        Task<User> GetById(long Id);
    }
}
