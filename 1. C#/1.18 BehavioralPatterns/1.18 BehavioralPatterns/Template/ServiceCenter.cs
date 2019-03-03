using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Template
{
    class ServiceCenter : Reparation
    {
        public override void Assembly()
        {
            Console.WriteLine("Service Center Worker: Assembly careful with special instruments.");
        }

        public override void Desassembly()
        {
            Console.WriteLine("Service Center Worker: Desassembly careful with special instruments.");
        }

        public override void RepairDetail()
        {
            Console.WriteLine("Service Center Worker: Repair with a certain garantee.");
        }
    }
}
