using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
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
            var result = _context.Users.Find(Id);//DbSet.Where(x=>x.Id.Equals(Id)).FirstOrDefault();
            return result;
        }

        public IList<User> GetUsers()
        {
            return _context.Users.AsNoTracking().ToList();
        }

        public IList<User> GetInterns()
        {
            var list = _context.Users.Join(_context.Interns,
                user => user.Id,
                intern => intern.UserId,
                (user,intern)=>user).ToList();
            return list;
        }

        public IList<User> GetMenthors()
        {
            var list = _context.Users.Join(_context.Menthors,
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

        public void UpdateUser(long userId, string newFName, string newLName, string newPhone, DateTime newdDBirth)
        {
            User user = _context.Users.Find(userId);
            user.FirstName = newFName;
            user.LastName = newLName;
            user.PhoneNumber = newPhone;
            user.DateOfBirth = newdDBirth;
            _context.Update(user);
            Save();
        }

        public IList<User> GetUsersDetails()
        {
            var list = _context.Users.ToList();

            return list;
        }

        public User GetUserDetails(long id)
        {
            var user = _context.Users.Where(x=>x.Id.Equals(id)).FirstOrDefault();

            return user;
        }
    }
}
