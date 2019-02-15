using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID2.LCP
{
    public class Horse : IRunning
    {
        public void Run()
        {
            Console.WriteLine("Horse Run");
        }
    }
}
