using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepositorty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository.ComplexRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly MyAppContext _context;
        protected readonly DbSet<User> DbSet;

        public UserRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public User GetUserById(long Id)
        {
            return DbSet.Find(Id);
        }

        public IList<User> GetUsers()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public IList<User> GetInterns()
        {
            var list = DbSet.Join(_context.Interns,
                user => user.Id,
                intern => intern.UserId,
                (user,intern)=>user).ToList();
            return list;
        }

        public IList<User> GetMenthors()
        {
            var list = DbSet.Join(_context.Menthors,
                user => user.Id,
                menthor => menthor.UserId,
                (user, menthor) => user).ToList();
            return list;
        }

        //public long Count => _context.Users.Count();

        //public void Add(User element)
        //{
        //    DbSet.Add(element);
        //}

        //public void AddRange(IList<User> elements)
        //{
        //    DbSet.AddRange(elements);
        //}

        //public void Delete(User element)
        //{
        //    DbSet.Remove(element);
        //}

        //public void Delete(long id)
        //{
        //    DbSet.Remove(DbSet.Find(id));
        //}

        //public IList<User> GetAll()
        //{
        //    return DbSet.ToList();
        //}

        //public User GetById(long Id)
        //{
        //    return DbSet.Find(Id);
        //}

        //public IList<User> GetNext10(int skipNr)
        //{
        //    return DbSet.Skip(skipNr * 10).Take(10).ToList();
        //}

        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}
