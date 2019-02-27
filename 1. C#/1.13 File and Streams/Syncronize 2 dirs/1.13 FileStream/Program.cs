using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._13_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            new SyncDirectory(@"D:\Dir1", @"D:\Syncronize\Dir2");

            Console.WriteLine("Succes!");
            Console.ReadKey();
        }
    }
}
