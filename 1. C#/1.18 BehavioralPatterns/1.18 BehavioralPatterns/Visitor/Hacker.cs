using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    class Hacker : IVisitor
    {
        public void Visit(MyDataBase myDB)
        {
            Console.WriteLine("Hacker: Steal the data/ Change data...");
        }

        public void Visit(Files secretfiles)
        {
            Console.WriteLine($"Hacker: Steal the files...");
        }
    }
}
