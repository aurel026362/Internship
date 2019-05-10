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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(MyAppContext context) : base(context)
        {
        }

        public User GetUserById(long Id)
        {
            var result = _context.Users.Find(Id);
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
                    var menthor = _context.Menthors.FirstOrDefault(x => x.UserId.Equals(userId));

                    if (menthor != null)
                    {
                        _context.Menthors.Remove(menthor);
                    }
                    else
                    {
                        var intern = _context.Interns.FirstOrDefault(x => x.UserId.Equals(userId));
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

        public IList<RequestedUser> GetRequestedUsers()
        {
            var list = _context.RequestedUsers.AsNoTracking().ToList();

            return list;
        }

        public RequestedUser GetRequestedUser(long requestedUserId)
        {
            var requestedUser = _context.RequestedUsers.Find(requestedUserId);

            return requestedUser;
        }

        public void DeclineRequestedUser(long requestedUserId)
        {
            var requestedUser = _context.RequestedUsers.Find(requestedUserId);
            _context.RequestedUsers.Remove(requestedUser);
        }
    }
}
