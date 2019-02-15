using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Programmer:Worker
    {
        public Programmer(string name, int salary):base(name, salary)
        {

        }

        public override void Work()
        {
            Console.WriteLine("Programmer work");
        }
    }
}
