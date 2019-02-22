using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    class EventForBank
    {
        public void Notify(object sender, StudentEventArgs e)
        {
            Console.WriteLine("For Bank : " + e.Message);
        }
    }
}
