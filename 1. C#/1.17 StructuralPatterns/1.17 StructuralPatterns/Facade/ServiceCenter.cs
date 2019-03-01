using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Facade
{
    class ServiceCenter
    {
        AssemblyDisDev assemDev;
        Checking ch;
        Repairing repair;

        public ServiceCenter(AssemblyDisDev newAssem, Checking newFindDet, Repairing newRepairing)
        {
            this.assemDev = newAssem;
            this.ch = newFindDet;
            this.repair = newRepairing;
        }

        public void BrokeVideoAdapter(string source)
        {
            assemDev.Disassembly(source);
            ch.Check(source);
            repair.ChangeDetail();
            assemDev.Assembly(source);
        }

        public void BrokeMouse(string source)
        {
            assemDev.Disassembly(source);
            ch.Check(source);
            repair.Repair();
            assemDev.Assembly(source);
        }
    }
}
