using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._19_ioCDI
{
    class Book : IRead
    {
        public void Read()
        {
            Console.WriteLine("Person read a book.");
        }
    }
}
