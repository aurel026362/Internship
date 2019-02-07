using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            ocp o_c_p = new ocp();
            lcp l = new lcp();
            ISP isp = new ISP();
        }
    }
}
