using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Facade
{
    class Checking
    {
        public void Check(string source)
        {
            Console.WriteLine($"In {source} check what is broke!");
        }
    }
}
