using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    public class StudentEventArgs:EventArgs
    {
        public string Message { get; private set; }

        public StudentEventArgs(string newmessage)
        {
            this.Message = newmessage;
        }
    }
}