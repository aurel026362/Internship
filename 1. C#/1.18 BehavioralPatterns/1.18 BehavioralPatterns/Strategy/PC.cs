using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Strategy
{
    class PC
    {
        public string name;
        public IReadable storage { get; set; }
    
        public PC(string newName, IReadable newStorage)
        {
            name = newName;
            storage = newStorage;
        }

        public void Read()
        {
            storage.Read();
        }
    }
}
