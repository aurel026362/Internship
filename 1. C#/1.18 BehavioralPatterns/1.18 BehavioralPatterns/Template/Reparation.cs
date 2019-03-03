using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Template
{
    abstract class Reparation
    {
        public void Repair()
        {
            Desassembly();
            CheckDevice();
            RepairDetail();
            Assembly();
        }

        public virtual void CheckDevice()
        {
            Console.WriteLine("Auto detect problem!");
        }

        public abstract void Assembly();
        public abstract void Desassembly();
        public abstract void RepairDetail();

    }
}
