using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Strategy
{
    class SSD : IReadable
    {
        public void Read()
        {
            Console.WriteLine("SSD. Reads data very fast.");
        }
    }
}
