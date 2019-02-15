using SOLID2.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{

    //ISP

    public class Landline:ICalling
    {
        public void Call()
        {
            Console.WriteLine("Possible to call, but don't take a photo");
        }
    }
}
