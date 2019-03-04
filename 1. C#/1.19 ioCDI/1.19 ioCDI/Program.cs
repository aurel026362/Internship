using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._19_ioCDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person(new Book());

            me.Read();

            me = new Person(new Newspaper());
            me.Read();

            Console.ReadKey();
        }
    }
}
