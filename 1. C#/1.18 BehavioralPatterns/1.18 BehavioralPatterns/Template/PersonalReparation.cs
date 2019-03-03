using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Template
{
    class PersonalReparation : Reparation
    {
        public override void Assembly()
        {
            Console.WriteLine("Assembly the device.");
        }

        public override void Desassembly()
        {
            Console.WriteLine("Desassemby the device.");
        }

        public override void RepairDetail()
        {
            Console.WriteLine("Repair the device(slow, poorly)");
        }

        public override void CheckDevice()
        {
            Console.WriteLine("Check visual what is broke.");
        }
    }
}
