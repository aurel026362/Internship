using System;
using System.Collections.Generic;
using System.Text;

namespace _4._0_Language_Basics
{
    class Howdy
    {

        static Howdy()
            // static constructor
        {

            String s= "Hello World!";
            hi(s);
        }

        static void hi(String say)
        {
            Console.WriteLine(say);
        }

    }
}
