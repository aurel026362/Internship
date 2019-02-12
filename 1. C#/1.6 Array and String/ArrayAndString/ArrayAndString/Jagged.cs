using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class Jagged
    {
        public Jagged()
        {
            Show(jagged());
        }

        private string[][,] jagged()
        {
            string[][,] jag = new string[2][,]
            {

                    new string[2,3] { {"aaa","bbb","cc"}, {"dd","ee", "ff" } },
                    new string[,] { { "Ion", "Gosa" }, { "Kiril", "Mihai"}, { "Jora", "Dima" } }
            };

            //Split function
            string text = "era odata ca niciodata o prea frumoasa fata";
            string[] t = text.Split(' ');

            foreach (string s in t)
            {
                Console.Write(s);
            }

            //Trim function
            string text2 = text.Trim(new char[] { 'a', 'e', 'n' });

            Console.WriteLine("\n" + " Dupa 'Trim' : " + text2);
            if (String.Compare(jag[0][0, 0], jag[1][2, 1]) < 0)
            {
                Console.WriteLine("Pozitia dupa aflabet este mai mica");
            }

            //Insert function
            jag[0][0, 1] = jag[0][0, 1].Insert(2, "zzz");

            //Console.WriteLine("Jag j[1][0,2] contine string-ul 'Gosa' "+String.Contains());
            return jag;
        }

        private void Show(string[][,] jag)
        {
            foreach (string[,] s in jag)
            {
                PrintBiArray(s);
                Console.WriteLine("=========");
            }
            Console.WriteLine();
        }

        private static int getBiArrayRowLen(string[,] str)
        {
            int n = 0;
            string temp;
            bool a = true;
            while (a)
            {
                try
                {
                    temp = str[n, 0];
                    n++;
                }
                catch
                {
                    a = false;
                }
            }
            return n;
        }

        public static void PrintBiArray(string[,] str)
        {
            int arrayRowLen = getBiArrayRowLen(str);
            for (int i = 0; i < arrayRowLen; i++)
            {
                for (int j = 0; j < str.Length / arrayRowLen; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
