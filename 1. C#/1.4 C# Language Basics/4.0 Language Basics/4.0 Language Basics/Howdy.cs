using System;
using System.Collections.Generic;
using System.Text;

namespace _4._0_Language_Basics
{
    class Howdy
    {
        
        static string s;

        // static constructor
        static Howdy()
        {
            s = "Hello World!";
            Hi(s);
        }

        static void Hi(string say)
        {
            Console.WriteLine(say);
        }

    }
}
