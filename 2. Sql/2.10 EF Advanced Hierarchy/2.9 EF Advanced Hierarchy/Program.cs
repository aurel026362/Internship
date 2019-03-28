using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using _2._9_EF_Advanced_Hierarchy.Configurations;
using System.Threading;
using _2._9_EF_Advanced_Hierarchy.Tables;
using System.Collections.Generic;

namespace _2._9_EF_Advanced_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread myThread = new Thread(new ThreadStart(OtherTransaction));
            //Console.WriteLine("--------");
            //myThread.Start();

            //AppContext context = new AppContext();

            //var mark = context.ThemeMarks.FirstOrDefault();

            //mark.Comment = "can be better";
            //context.ThemeMarks.Update(mark);
            //context.SaveChanges();

            using (AppContext context = new AppContext())
            {

                //Polymorphic query
                var list = context.Users.ToList();

                Console.WriteLine("Users:");

                foreach (var item in list)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                //NONPolymorphic query
                var interns = context.Users.OfType<UserIntern>().ToList();

                Console.WriteLine("\nInterns:");

                foreach (var intern in interns)
                {
                    Console.WriteLine(intern.FirstName + " " + intern.LastName);
                }

                //new Selecting(context);

                //new Trans();
            }

            Console.ReadKey();
        }

        private static void OtherTransaction()
        {
            AppContext context = new AppContext();

            var mark = context.ThemeMarks.FirstOrDefault();
            mark.Comment = "So so";
            context.ThemeMarks.Update(mark);
            context.SaveChanges();

        }
    }
}
