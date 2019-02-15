using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.Interfaces
{
    class MonthOp
    {
        Month month = new Month();

        public MonthOp()
        {
            Show();
        }

        void Show()
        {
            Console.WriteLine("Show every second month:");
            foreach (var m in month)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
    }
}
