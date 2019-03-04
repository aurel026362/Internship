using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace _1._14EvolutionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicExample();
            OptionalParExample();
            GettingOtherConst();
            NamedArgumentsEx();
            EvalOrderExample();
            OptionalNamedEx();
            PropertesAutoImplEx();
            DictionaryInitEx();
            NewExceptionEx();
            OutVarExample();
            TupleExample();
            PatternMatchEx();
            RefExample();

            DataProgram();

            ReadKey();
        }

        static void DataProgram([CallerMemberName] string memberName = null,
             [CallerFilePath] string filePath = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            WriteLine(memberName);
            WriteLine(filePath);
            WriteLine(lineNumber);
        }

        private static void RefExample()
        {
            WriteLine("Ref Method example: ");
            int n = 2;
            ref int number = ref ReferenceMethodEx(ref n);

            WriteLine("Ref value: " + n);
        }

        private static ref int ReferenceMethodEx(ref int number)
        {
            return ref number;
        }

        private static void PatternMatchEx()
        {
            WriteLine("Pattern Match example: ");

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
            WriteLine();
        }

        private static void TupleExample()
        {
            WriteLine("Tuple example: ");

            (int num1, int num2) Example(int a, int b) => (a, b);

            var (_,num2) = Example(2, 3);

            WriteLine($"{num2}");
            WriteLine();
        }

        private static void OutVarExample()
        {
            WriteLine("OutVar example: ");

            int c;
            OutEx(out c);

            WriteLine("Out value: " + c + "\n");
        }

        private static void OutEx(out int a)
        {
            a = 23;
        }

        private static void NewExceptionEx()
        {
            WriteLine("New Exception example: ");

            int? c = 0;
            int? a = 2;

            try
            {
                c = 0;
                a = 2 / c;
                if (c == null) throw new Exception(nameof(c) + " isNull!");
            }
            catch (Exception ex) when (c == 0)
            {
                WriteLine("Posible");
                throw;
            }
            catch (Exception ex) when (c != 0)
            {
                WriteLine("Imposible");
            }

            WriteLine();
        }

        private static void DictionaryInitEx()
        {
            WriteLine("Dictionary Init example: ");
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

            WriteLine();
        }

        private static void PropertesAutoImplEx()
        {
            WriteLine("Propertes auto impl example: ");

            PropAutoImpl pai = new PropAutoImpl();

            pai.Propertes = 4;
            int sum = pai.Sum();

            WriteLine(pai.Propertes);
            WriteLine("Sum of propertes: " + sum);
            WriteLine();
        }

        private static void OptionalNamedEx()
        {
            WriteLine("Optional Name example: ");
            Person person = new Person(
                newLName: "Ciocan",
                newFName: "Artur",
                newage: 12
            );

            WriteLine(person?.fName ?? "IsEmpty");
            WriteLine();
        }
        
        private static void EvalOrderExample()
        {
            WriteLine("Order params example: ");
            int Example(int a)
            {
                return a;
            }

            int Sum(int x, int y, int z)
            {
                return (x + y + z);
            }

            int res = Sum(Example(1), Example(2), Example(3));

            WriteLine("Sum: " + res);
            WriteLine();
        }

        private static void NamedArgumentsEx()
        {
            WriteLine("Named arguments example: ");
            int Example(int a, int b)
            {
                return a + b;
            }

            int c = Example(a: 1, b: 2);

            WriteLine("Sum: {0} ", c);
            WriteLine();
        }

        private static void GettingOtherConst()
        {
            WriteLine("Getting other const example: ");
            void Example(string a, string b)
            {
                string d = a ?? "IsNull";
                string z = b ?? "IsNull2";
                WriteLine(d + "\n" + z);
            }

            Example(null, "ValueExist");
            WriteLine();
        }
        
        private static void OptionalParExample()
        {
            WriteLine("Optional parameters example: ");
            //Optional parameters example
            OptionalParam(1);
            OptionalParam(1, 2);
            OptionalParam(1, 2, 3);
            WriteLine();
        }

        private static void OptionalParam(int a, int b = 2, int c = 4)
        {
            Write(a + " " + b + " " + c);
            WriteLine();
        }

        private static void DynamicExample()
        {
            WriteLine("Dynamic example: ");

            //Dynamic example
            dynamic array = new int[3] { 1, 2, 3 };
            
            int first = (int)array[0]; 

            foreach (var item in array)
            {
                //Write(item.toString()); ERROR
                Write(item + " ");
            }

            WriteLine(first);
            WriteLine("\n");
        }
    }
}
