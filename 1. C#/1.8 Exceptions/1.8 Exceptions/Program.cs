using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var e = new Except();
#elif RELEASE
            Console.WriteLine("This is RELEASE!");
#else
            Console.WriteLine("This isn't Debug!");
#endif
            Console.ReadKey();
        }
    }
}
