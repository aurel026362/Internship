using System;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext context = new AppContext();

            var list = context.Students;
            Console.ReadKey();
        }
    }
}
