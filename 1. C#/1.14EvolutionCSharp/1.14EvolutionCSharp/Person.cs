using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._14EvolutionCSharp
{
    class Person
    {
        private int id;
        public string fName;
        public string lName;
        public int age;

        public Person(string newFName, string newLName, int newage)
        {
            this.fName = newFName;
            this.lName = newLName;
            this.age = newage;
        }
        
    }
}
