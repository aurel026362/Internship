using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._14EvolutionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        private static void OptionalNamedEx()
        {
            ClassExample ce = new ClassExample(
                newL: "Ciocan",
                newF: "Artur",
                newage: 12
            );
        }
        
        private static void EvalOrderExample()
        {
            int Example(int a)
            {
                return a;
            }

            int Sum(int x, int y, int z)
            {
                return (x + y + z);
            }

            int res = Sum(Example(1), Example(2), Example(3));

            Console.WriteLine(res);
        }

        private static void NamedArgumentsEx()
        {
            int Example(int a, int b)
            {
                return a + b;
            }

            int c = Example(a: 1, b: 2);

            Console.WriteLine(c);
        }

        private static void GettingOtherConst()
        {
            void Example(string a, string b)
            {
                string d = a ?? "asd";
                string z = b ?? "zxc";
            }

            Example(null, "da");
        }
        
        private static void OptionalParExample()
        {
            //Optional parameters example
            OptionalParam(1);
            OptionalParam(1, 2);
            OptionalParam(1, 2, 3);
        }

        private static void DynamicExample()
        {
            //Dynamic example
            dynamic a;
        }

        private static void OptionalParam(int a, int b = 2, int c = 4)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
