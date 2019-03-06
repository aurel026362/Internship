using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    class OperationsRep
    {
        public OperationsRep()
        {
            IRepository<User> uRep = new UserRepository(
                new List<User>()
                { 
                new User { Id = 1, name = "ion", age = 12, gender = "m" },
                new User { Id = 2, name = "fiona", age = 23, gender = "f" },
                new User { Id = 3, name = "mihai", age = 16, gender = "m" },
                new User { Id = 4, name="nichita", age = 19, gender="m" }
                }
            );
            
            uRep.Delete(2);

            var firstUser = uRep.GetUser(3);
            Console.WriteLine($"{firstUser.name} {firstUser.age}");

            List<User> newUsers = (List<User>)uRep.GetUsersList();

            Console.WriteLine("New List IS:");

            foreach(var user in newUsers)
            {
                Console.WriteLine($"{user.name} {user.age} {user.gender}");
            }
        }
    }
}
