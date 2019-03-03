using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    class User : IVisitor
    {
        string name;

        public User(string newName)
        {
            name = newName;
        }

        public void Visit(MyDataBase myDB)
        {
            Console.WriteLine($"User {name}: Check his data.");
        }

        public void Visit(Files secretFiles)
        {
            Console.WriteLine($"User {name} use files.");   
        }
    }
}
