using System;
using static System.Console;
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
            DynamicExample();
            ReadKey();
        }

        private static void PatternMatchEx()
        {
            Person person = new Person(
                newLName: "Ciocan",
                newFName: "Artur",
                newage: 12
            );
            if (person is Person)
                WriteLine($"Var person is Instance of Person!");

            CheckPerson(person);

            void CheckPerson(object obj)
            {
                Person newperson = obj as Person;
                if (newperson == null)
                    WriteLine("This isn't person!");
                else
                    WriteLine("This is person!");
            }
        }

        private static void TupleExample()
        {
            (int num1, int num2)Example(int a, int b)
            {
                return (a, b);
            }

            var (_,num2) = Example(2, 3);

            WriteLine($"{num2}");
        }
        private static void OutVarExample()
        {
            int c;
            OutEx(out c);
        }

        private static void OutEx(out int a)
        {
            a = 23;
        }

        private static void NewExceptionEx()
        {
            int c = 0;
            int a = 2;

            try
            {
                c = 0;
                a = 2 / c;
            }
            catch (Exception ex) when (c == 0)
            {
                WriteLine("Posible");
            }
            catch (Exception ex) when (c != 0)
            {
                WriteLine("Imposible");
            }
        }
        private static void DictionaryInitEx()
        {
            var dict = new Dictionary<string, string>()
            {
                ["me"] = "Aurel",
                ["you"] = "Nicu",
                ["he"] = "Dima"
            };
            
            foreach (var item in dict)
            {
                WriteLine($"{item.Key} : {item.Value}");
            }
        }
        private static void PropertesAutoImplEx()
        {
            PropAutoImpl pai = new PropAutoImpl();
            pai.Propertes = 4;
            WriteLine(pai.Propertes);
        }
        private static void OptionalNamedEx()
        {
            Person person = new Person(
                newLName: "Ciocan",
                newFName: "Artur",
                newage: 12
            );
            WriteLine(person?.fName ?? "IsEmpty");
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

            WriteLine(res);
        }

        private static void NamedArgumentsEx()
        {
            int Example(int a, int b)
            {
                return a + b;
            }

            int c = Example(a: 1, b: 2);

            WriteLine(c);
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

        private static void OptionalParam(int a, int b = 2, int c = 4)
        {
            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
        }

        private static void DynamicExample()
        {
            //Dynamic example
            dynamic array = new int[3] { 1, 2, 3 };

            foreach (var item in array)
            {
                Write(item.toString());
            }
            WriteLine();
        }
    }
}
