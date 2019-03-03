using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Strategy
{
    class HDD : IReadable
    {
        public void Read()
        {
            Console.WriteLine("HDD. Read's data at normal speed.");
        }
    }
}
