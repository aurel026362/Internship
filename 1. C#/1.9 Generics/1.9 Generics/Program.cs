using _1._9_Generics.Generics;
using _1._9_Generics.Nullable;
using _1._9_Generics.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics
{
    class Program
    {
        enum Operation:int { Exit =0, Generic, Collection, RepositoryP}

        static void Main(string[] args)
        {
            int n = -1;
            Operation op;
            while (n != 0)
            {
                Console.WriteLine();
                Console.WriteLine("   MENU");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Generic");
                Console.WriteLine("2 - Collections and Nullable");
                Console.WriteLine("3- Repository Pattern");
                Console.WriteLine("-----------------------------");
                Console.Write("Chose operation: ");
                n = Convert.ToInt32(Console.ReadLine());
                op = (Operation)n;

                Console.Clear();

                switch (op)
                {
                    case Operation.Exit: Console.WriteLine("Exit!"); break;
                    case Operation.Generic: new GenericsOp(); break;
                    case Operation.Collection: new NullableOp(); break;
                    case Operation.RepositoryP: new RepositoryOp(); break;
                    default: Console.WriteLine("Don't exist this operation!"); break;
                }
            }
            Console.ReadKey();
        }
    }
}
