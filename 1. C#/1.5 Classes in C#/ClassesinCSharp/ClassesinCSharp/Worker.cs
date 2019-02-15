using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    abstract class Worker:Person, IWork
    {
        public int salary;

        public Worker(string name, int salary):base(name)
        {
            this.salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Worker work");
        }

    }
}
