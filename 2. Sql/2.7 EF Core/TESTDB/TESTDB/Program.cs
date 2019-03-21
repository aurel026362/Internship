using System;
using System.Linq;
using TESTDB.Repository;

namespace TESTDB
{
    class Program
    {
        static void Main(string[] args)
        {
            TESTDBContext context = new TESTDBContext();

                var markUsers = context.ThemeMarks.Where(x=>(x.Mark>8)).Select(x=>new { F=x.Intern.User.FirstName, L=x.Intern.User.LastName, D=x.Theme.Name, M=x.Mark });
             
                foreach (var item in markUsers)
                {
                    Console.WriteLine($"{item.F} {item.L} {item.D} {item.M}");
                }
                


            Repository<Users> repository = new Repository<Users>(new TESTDBContext());
            var list = repository.Get();

            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine("The End!");
            Console.ReadKey();
        }
    }
}
