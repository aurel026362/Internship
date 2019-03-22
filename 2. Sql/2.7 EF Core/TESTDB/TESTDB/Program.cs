using Microsoft.EntityFrameworkCore;
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

            var interns = context.Interns.Include(x => x.User).Include(x => x.ThemeMarks);
            var themes = context.Themes.ToList();
            foreach (var i in interns)
            {
                Console.WriteLine(i.User.FirstName);
                foreach (var m in i.ThemeMarks)
                {
                    var theme = themes.Where(x => x.Id == m.ThemeId).FirstOrDefault();
                    Console.WriteLine("\t" + theme.Name + " " + m.Mark);
                }
            }
            //Console.WriteLine(user);

            //var usermarks = users;


            Console.WriteLine("---------------------------------");
                var markUsers = context.ThemeMarks.Where(x=>(x.Mark>8)).Select(x=>new { F=x.Intern.User.FirstName, L=x.Intern.User.LastName, D=x.Theme.Name, M=x.Mark });
             
                foreach (var item in markUsers)
                {
                    Console.WriteLine($"{item.F} {item.L} {item.D} {item.M}");
                }

            Console.WriteLine("--------------");

            Repository<Users> repository = new Repository<Users>(new TESTDBContext());

            var noName = repository.FindById(2);

            Console.WriteLine(noName.FirstName);

            //var list = repository.Get();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}

            Console.WriteLine("The End!");
            Console.ReadKey();
        }
    }
}
