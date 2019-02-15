using SOLID2.LCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{

    //ICP
    public class Human : IRunning, ISwimming
    {
        public void Run()
        {
            Console.WriteLine("Human run");
        }

        public void Swim()
        {
            Console.WriteLine("Human swim");
        }
    }
}
