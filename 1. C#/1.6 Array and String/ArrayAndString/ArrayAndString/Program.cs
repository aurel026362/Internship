using System;

namespace ArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            while (n != 0)
            {
                Console.WriteLine(@"     MENIU        ");
                Console.WriteLine("1 - Array unidimensional ");
                Console.WriteLine("2 - Array bidimensional");
                Console.WriteLine("3 - Array multidimensional");
                Console.WriteLine("4 - Array in Array(Jagged)");
                Console.WriteLine("5 - Operation with StringBuilder");
                Console.WriteLine("---------------------------");
                Console.Write("Alege operatiunea: ");
                n = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1: Arrays ar = new Arrays(); break;
                    case 2: ArrayBidim ab = new ArrayBidim(); break;
                    case 3: ArrayMultiDim am = new ArrayMultiDim(); break;
                    case 4: Jagged jag = new Jagged(); break;
                    case 5: StringOp so = new StringOp();break;
                    case 0: Console.WriteLine("Iesire din meniu!"); break;

                    default: Console.WriteLine("Nu exista astfel de operatiune!"); break;
                }
            }
        }
    }
}
