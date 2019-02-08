using System;


namespace _4._0_Language_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using static constructor
            Howdy howdy = new Howdy();

            Console.WriteLine();

            //Using boxing/unboxing
            //instances of value types and reference types
            array ar = new array();

            //Threading
            Console.WriteLine();
            Console.WriteLine("THREADING...");
            Threading_test test1 = new Threading_test("-------- ",9);
            Threading_test test2 = new Threading_test("|||||||| ",9);
            Threading_test test3 = new Threading_test("//////// ", 9);
            Threading_test test4 = new Threading_test("++++++++ ", 9);

            Console.ReadKey();
        }
    }
}
