using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Tester : Worker
    {
        public Tester(string name, int salary) : base(name, salary)
        {

        }

        public override void Work()
        {
            Console.WriteLine("Tester work");
        }
    }
}
