using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class ArrayBidim
    {

        public ArrayBidim()
        {
            ArBid();
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
    }
}
