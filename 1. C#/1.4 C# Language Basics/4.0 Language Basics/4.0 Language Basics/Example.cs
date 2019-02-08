using System;
using System.Collections.Generic;
using System.Text;

namespace _4._0_Language_Basics
{
    class Example
    {
        public  Example()
        {
            int[] v = { 1, 2, 3, 4 };

            Console.WriteLine("The initial array: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }

            Initialize(ref v);

            Console.WriteLine();
            Console.WriteLine("Modified array: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }

            Console.WriteLine();

            int s;
            OutExample(out s, v);
            Console.WriteLine("Sum at modified array = " + s);

        }

        // Ref type
        private void Initialize(ref int[] vec)
        {

            //Boxing 
            object n = vec.Length;

            //Unboxing 
            int m = (int) n;

            for (int i = 0; i < m; i++)
            {
                vec[i] = vec[i] * vec[i];
            }
        }


        // Function with out parameter
        private void OutExample(out int sum, int [] vec)
        {
            int n = vec.Length;
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vec[i];
            }
        }
       
    }
}
