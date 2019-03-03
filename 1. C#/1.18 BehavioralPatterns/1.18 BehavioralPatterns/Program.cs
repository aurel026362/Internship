using _1._18_BehavioralPatterns.OBServer;
using _1._18_BehavioralPatterns.Strategy;
using _1._18_BehavioralPatterns.Template;
using _1._18_BehavioralPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------OBSERVER--------------------------------
            Console.WriteLine("-------OBSERVER EXAMPLE------------- \n");

            Application shazam = new Application("Shazam", "2.3.1");

            List<IClient> clients = new List<IClient>
            {
                new Client("Aurel", shazam),
                new Client("Nicu", shazam),
                new VipClient("Dima", shazam),
                new Client("Vlad", shazam)
            };

            shazam.Notify();

            //---------------STRATEGY------------------------------
            Console.WriteLine("\n-------STRATEGY EXAMPLE------------- \n");

            PC pc = new PC("Acer", new HDD());

            pc.Read();
            pc.storage = new SSD();

            pc.Read();

            //-------------TEMPLATE---------------------------------
            Console.WriteLine("\n--------Template Example------------ \n");

            Reparation personal = new PersonalReparation();
            Reparation serviceCenter = new ServiceCenter();

            Console.WriteLine("My reparation:");
            personal.Repair();

            Console.WriteLine("\nService Center Reparation:");
            serviceCenter.Repair();

            //------------VISITOR------------------------------------
            Console.WriteLine("\n----------Visitor Example-------------");

            MyDataBase myDB = new MyDataBase("Facebook");
            Files files = new Files();

            Developer developer = new Developer("George");
            User user = new User("Aurel");
            Hacker hacker = new Hacker();

            files.Accept(developer);
            files.Accept(hacker);

            myDB.Accept(developer);
            myDB.Accept(user);

            Console.WriteLine("\n OR: ");

            Administrator admin = new Administrator();

            admin.AddElement(myDB);
            admin.AddElement(files);
            admin.Accept(developer);
            admin.Accept(user);
            admin.RemoveElement(files);

            Console.WriteLine("Remove operations with files.");

            admin.Accept(developer);
            admin.Accept(user);
            Console.ReadKey();
        }
    }
}
