using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    class EventForMe
    {
        public void Notify(object sender, MovingEventArgs e)
        {
            Console.WriteLine("For me : " + e.Message);
        }
    }
}
