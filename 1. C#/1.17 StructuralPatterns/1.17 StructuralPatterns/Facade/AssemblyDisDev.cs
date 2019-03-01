using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Facade
{
    class AssemblyDisDev
    {
        public void Assembly(string device)
        {
            Console.WriteLine($"Assembly {device}");
        }

        public void Disassembly(string device)
        {
            Console.WriteLine($"Disassembly {device}");
        }
    }
}
