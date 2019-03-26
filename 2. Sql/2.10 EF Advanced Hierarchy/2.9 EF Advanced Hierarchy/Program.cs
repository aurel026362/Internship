using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using _2._9_EF_Advanced_Hierarchy.Configurations;
using System.Threading;
using _2._9_EF_Advanced_Hierarchy.Tables;

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

            new Selecting();

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
