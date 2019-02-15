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

            Console.Write("\' Escape \a");
            Console.WriteLine(@" Caracters");

            //Pad Left
            Console.WriteLine(jag[0][0, 0].PadLeft(5,'.'));

            //Pad Right
            Console.WriteLine(jag[0][0, 1].PadRight(6, '-'));

            //Pad Left Default
            Console.WriteLine(jag[0][0,1].PadLeft(7));

            //ToUpper
            Console.WriteLine(jag[1][0, 1].ToUpper());

            //ToLower
            Console.WriteLine(jag[1][0, 1].ToLower());

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
                for (int i = 0; i < s.GetLength(0); i++)
                {
                    for (int j = 0; j < s.GetLength(1); j++)
                    {
                        Console.Write(s[i, j] + " ");
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("=========");
            }
            Console.WriteLine();
        }
    }
}
