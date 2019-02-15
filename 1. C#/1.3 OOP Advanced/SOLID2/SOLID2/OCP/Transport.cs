using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{

    //OCP
    abstract class Transport
    {
        public virtual void Move()
        {
            Console.WriteLine("Transport - Move");
        }
    }
}
