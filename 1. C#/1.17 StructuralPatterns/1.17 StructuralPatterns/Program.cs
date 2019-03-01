using _1._17_StructuralPatterns.Decorator;
using _1._17_StructuralPatterns.Facade;
using _1._17_StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Example: ");
            new Client("Aurel");

            Console.WriteLine("\nFacade Example: \n");
            new Client2("Dima");

            Console.WriteLine("\nDecorator Example: ");
            new Client3("Nicu");

            Console.ReadKey();
        }
    }
}
