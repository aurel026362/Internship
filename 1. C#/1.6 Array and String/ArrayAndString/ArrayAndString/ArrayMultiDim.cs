using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class ArrayMultiDim
    {

        public ArrayMultiDim()
        {
            ArMultiDim();
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
    }
}
