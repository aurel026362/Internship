using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Facade
{
    class Client2
    {
        public string name;
        public Client2(string newName)
        {
            this.name = newName;

            ServiceCenter serviceCenter = new ServiceCenter(new AssemblyDisDev(), new Checking(), new Repairing());

            Console.WriteLine("Video adapter broke...");
            serviceCenter.BrokeVideoAdapter("VideoAdapter");

            Console.WriteLine("\nMouse broke...");
            serviceCenter.BrokeMouse("Mouse");
        }
    }
}
