using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    public class MovingEventArgs:EventArgs
    {
        public string Message { get; private set; }

        public MovingEventArgs(string newmessage)
        {
            this.Message = newmessage;
        }
    }
}