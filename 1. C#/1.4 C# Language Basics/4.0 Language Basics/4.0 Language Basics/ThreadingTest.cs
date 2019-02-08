using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _4._0_Language_Basics
{
    class ThreadingTest
    {
        public ThreadingTest(String name, int n)
        {
            Thread mythread = new Thread(Test);
            mythread.Name = name;
            mythread.Start(n);
        }

        private void Test(object n)
        {
            int m = (int) n;

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" "+(i+1)+" ");
                Thread.Sleep(0);
            }
        }

    }
}
