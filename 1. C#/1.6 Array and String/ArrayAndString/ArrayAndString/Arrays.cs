using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class Arrays
    {

        public Arrays()
        {
            int n = -1;
            while (n != 0)
            {
                Console.WriteLine(@"     MENIU        ");
                Console.WriteLine("1 - Array unidimensional ");
                Console.WriteLine("2 - Array bidimensional");
                Console.WriteLine("3 - Array multidimensional");
                Console.WriteLine("4 - Array in Array(Jagged)");
                Console.WriteLine("5");
                Console.WriteLine("---------------------------");
                Console.Write("Alege operatiunea: ");
                n = Convert.ToInt16(Console.ReadLine());

                switch (n)
                {
                    case 1: ArUnid(); break;
                    case 2: ArBid(); break;
                    case 3: ArMultiDim(); break;
                    case 4: Show(Jagged());  break;
                    case 0: Console.WriteLine("Iesire din meniu!"); break;

                    default: Console.WriteLine("Nu exista astfel de operatiune!"); break;
                }
            }
        }

        private void Show(int[] a)
        {
            int m = a.Length;
            for (int i = 0; i < m; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        private void Show(int[,] a, int n, int m)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public void Show(int[,,] a, int n, int m, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int z = 0; z < k; z++)
                    {
                        Console.Write(a[i, j, z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int[] ArUnid()
        {
            int[] a = { 1, 2, 3, 4, 5 };

            Show(a);

            Array.Reverse(a);
            Console.WriteLine("Vector invers:");
            Show(a);

            Console.WriteLine("Vector sortat: ");
            Array.Sort(a);
            Show(a);

            Console.WriteLine("RANK " + "{0}: {1} dimension(s)", a.ToString(), a.Rank);

            Array.Resize(ref a, 4);
            Console.WriteLine("New size array: " + a.Length + " \nResized array: ");
            Show(a);

            Console.WriteLine("Clear array: ");
            Array.Clear(a, 0, 2);
            Show(a);

            Console.WriteLine("Elementul 2 exista in array: " + Array.Exists(a, element => element == 2));

            Show(a);

            Console.WriteLine("Afiseaza elementul cu index-ul 2 este " + Array.IndexOf(a, 2));

            int[] el = Array.FindAll(a, element => element > 0);
            Console.Write("Elementele mai mari ca 0 sunt: ");
            foreach (int e in el)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            int[] b = new int[3] { 7, 8, 9 };

            //Rescrie continutul vectorului a
            Console.WriteLine("Adaugarea altui vector in cel de baza ");
            Array.Copy(b, 0, a, 0, 3);

            IReadOnlyCollection<int> result = Array.AsReadOnly(a);

            Show(a);
            return a;
        }

        public void ArBid()
        {
            int[,] mat = new int[2, 3]
            {
                {1 ,2, 3},
                {4, 5, 6}
            };

            int[] a = new int[] { 1, 2, 3, 4 };
        
            Show(mat, 2, 3);
        }

        private void ArMultiDim()
        {
            int[,,] ars = new int[2, 2, 3];

            Console.WriteLine("Input values: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        ars[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                
            }

            Show(ars, 2, 2, 3);
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

        private string[][,] Jagged()
        {
            string[][,] jag = new string[2][,]
            {

                    new string[2,3] { {"aaa","bbb","cc"}, {"dd","ee", "ff" } },
                    new string[,] { { "Ion", "Gosa" }, { "Kiril", "Mihai"}, { "Jora", "Dima" } }
            };

            string text = "era odata ca niciodata o prea frumoasa fata";
            string[] t = text.Split(' ');
            
            foreach (string s in t)
            {
                Console.Write(s);
            }

            string text2 = text.Trim(new char[] { 'a', 'e', 'n' });

            Console.WriteLine("\n" + " Dupa 'Trim' : " + text2);
            if (String.Compare(jag[0][0, 0], jag[1][2, 1])<0) {
                Console.WriteLine("Pozitia dupa aflabet este mai mica");
            }

            jag[0][0, 1] = jag[0][0, 1].Insert(2, "zzz");
            
            //Console.WriteLine("Jag j[1][0,2] contine string-ul 'Gosa' "+String.Contains());
            return jag;
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