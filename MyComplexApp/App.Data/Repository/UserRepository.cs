using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly MyAppContext _context;

        public UserRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public async Task<User> GetById(long Id)
        {
            return await _context.Users.FindAsync(Id);
        }


    }
}
