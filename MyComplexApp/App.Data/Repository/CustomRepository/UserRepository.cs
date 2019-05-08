using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
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
            var interns = _context.Interns.Include(x => x.User).Select(x => new User()
            {
                Id = x.Id,
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                Email = x.User.Email
            }).ToList();
            return interns;
        }

        public IList<User> GetMenthors()
        {
            var menthors = _context.Menthors.Select(x => x.User).ToList();
            return menthors;
        }

        public IList<User> GetInternsAndMenthors()
        {
            var interns = GetInterns();
            var menthors = GetMenthors();
            var users = interns;

            foreach (var item in menthors)
            {
                users.Add(item);
            }

            return users;
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
            //var role = _context.Roles.Where(x => x.Users.Select(y => y.Id).Equals(1)).FirstOrDefault();

            return list;
        }

        public void AddIntern(Intern intern)
        {
            _context.Interns.Add(intern);
            _context.SaveChanges();
        }

        public void AddMenthor(Menthor menthor)
        {
            _context.Menthors.Add(menthor);
            _context.SaveChanges();
        }

        public void DeleteUser(long userId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var menthor = _context.Menthors.Where(x => x.UserId.Equals(userId)).FirstOrDefault();

                    if (menthor != null)
                    {
                        _context.Menthors.Remove(menthor);
                    }
                    else
                    {
                        var intern = _context.Interns.Where(x => x.UserId.Equals(userId)).FirstOrDefault();
                        if (intern != null)
                        {
                            _context.Interns.Remove(intern);
                        }
                    }

                    var user = _context.Users.Find(userId);
                    _context.Users.Remove(user);

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

        public void UpdateUser(User user)
        {
            var oldUser = GetUserById(user.Id);

            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.DateOfBirth = user.DateOfBirth;
            oldUser.Email = user.Email;
            oldUser.PhoneNumber = user.PhoneNumber;
            oldUser.PhoneNumberConfirmed = user.PhoneNumberConfirmed;
            oldUser.EmailConfirmed = user.EmailConfirmed;
            oldUser.TwoFactorEnabled = user.TwoFactorEnabled;
            oldUser.AccessFailedCount = user.AccessFailedCount;
            
            _context.Update(oldUser);
            _context.SaveChanges();
        }
    }
}
