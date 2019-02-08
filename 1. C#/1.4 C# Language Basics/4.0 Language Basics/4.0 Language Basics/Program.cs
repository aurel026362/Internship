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
            Example ar = new Example();

            //Threading
            Console.WriteLine();
            Console.WriteLine("THREADING...");
            ThreadingTest test1 = new ThreadingTest("-------- ",9);
            ThreadingTest test2 = new ThreadingTest("|||||||| ",9);
            ThreadingTest test3 = new ThreadingTest("//////// ", 9);
            ThreadingTest test4 = new ThreadingTest("++++++++ ", 9);

            Console.ReadKey();
        }
    }
}
