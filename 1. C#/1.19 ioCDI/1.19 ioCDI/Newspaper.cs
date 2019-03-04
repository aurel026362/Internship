using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._19_ioCDI
{
    class Newspaper : IRead
    {
        public void Read()
        {
            Console.WriteLine("Person read a newspaper.");
        }
    }
}
