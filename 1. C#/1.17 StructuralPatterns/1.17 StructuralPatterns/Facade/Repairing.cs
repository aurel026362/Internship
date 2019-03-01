using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Facade
{
    class Repairing
    {
        public void Repair()
        {
            Console.WriteLine($"Repair detail");
        }

        public void ChangeDetail()
        {
            Console.WriteLine($"Change detail!");
        }
    }
}
