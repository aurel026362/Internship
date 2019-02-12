using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Worker:Person, IWorking
    {
        public string functionWorker;

        public Worker(string name, string function):base(name)
        {
            functionWorker = function;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working");
        }
    }
}
