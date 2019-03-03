using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    class Developer : IVisitor
    {
        string name;

        public Developer(string newName)
        {
            name = newName;
        }

        public void Visit(MyDataBase myDB)
        {
            Console.WriteLine($"Developer {name}: work with data base...");
        }

        public void Visit(Files secretfiles)
        {
            Console.WriteLine($"Developer {name}: does not need of files.");
        }
    }
}
