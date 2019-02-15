using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class Arrays
    {

        public Arrays()
        {
            ArUnid();
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
        
        public void ArUnid()
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

            Console.WriteLine("Afiseaza elementul cu index-ul 2 este " + Array.IndexOf(a, 3));

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
        }
    }
}