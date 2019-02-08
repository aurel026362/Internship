using System;
using System.Collections.Generic;
using System.Text;

namespace _4._0_Language_Basics
{
    class Howdy
    {
        // static constructor
        static Howdy()
        {
            string s = "Hello World!";
            Hi(s);
        }

        static void Hi(string say)
        {
            Console.WriteLine(say);
        }

    }
}
