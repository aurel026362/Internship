using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using _2._9_EF_Advanced_Hierarchy.Configurations;
using System.Threading;

namespace _2._9_EF_Advanced_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext context = new AppContext();
            Thread myThread = new Thread(new ThreadStart(OtherTransaction));
            
            myThread.Start();

            var entity = context.Exchanges.FirstOrDefault();
            entity.InMDL = 19;
            context.Exchanges.Update(entity);
            context.SaveChanges();
            Console.ReadKey();
        }

        private static void OtherTransaction()
        {
            AppContext context = new AppContext();
            var other = context.Exchanges.FirstOrDefault();
            other.InMDL = 99;
            context.Exchanges.Update(other);
            context.SaveChanges();
        }
    }
}
