using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _4._0_Language_Basics
{
    class Threading_test
    {
        public Threading_test(String name, int n)
        {
            Thread mythread = new Thread(test);
            mythread.Name = name;
            mythread.Start(n);
        }

        private void test(object n)
        {
            for (int i = 0; i < (int) n; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" "+(i+1)+" ");
                Thread.Sleep(0);
            }
        }

    }
}
