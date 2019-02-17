using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Generics
{
    class Teacher
    {
        public string name;
        public int age;

        public void Actions(string s)
        {
            Console.WriteLine("This teacher by " + s);
        }
    }
}
