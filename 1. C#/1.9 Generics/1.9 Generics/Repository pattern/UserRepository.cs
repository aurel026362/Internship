using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    class UserRepository : IRepository<User>
    {
        List<User> users = new List<User>();

        public UserRepository(List<User> newUsers)
        {
            users = newUsers;
        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public void Delete(int id)
        {
            users.Remove(users.Find(x => x.Id == id));
        }

        public User GetUser(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }

        public IEnumerable<User> GetUsersList()
        {
            return users;
        }

        public void Update(int id, User newUser)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    users.Remove(user);
                    users.Add(newUser);
                }
            }
        }
    }
}
