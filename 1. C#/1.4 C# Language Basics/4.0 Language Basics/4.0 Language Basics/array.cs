using System;
using System.Collections.Generic;
using System.Text;

namespace _4._0_Language_Basics
{
    class array
{
        public  array()
        {
            int[] v = { 1, 2, 3, 4 };

            Console.WriteLine("The initial array: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }

            initialize(ref v);

            Console.WriteLine();
            Console.WriteLine("Modified array: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }

            Console.WriteLine();

            int s;
            out_example(out s, v);
            Console.WriteLine("Sum at modified array = " + s);

        }

        private void initialize(ref int[] vec) {
            // Ref type

            object n = vec.Length;
            //Boxing 

            int m = (int) n;
            //Unboxing 

            for (int i = 0; i < m; i++)
            {
                vec[i] = vec[i] * vec[i];
            }
        }

        private void out_example(out int sum, int [] vec)
        {
            // Function with out parameter
            int n = vec.Length;
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vec[i];
            }

        }

      

    }
}
