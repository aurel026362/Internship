using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID2.OCP
{
    class Plane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Plane - fly");
        }
    }
}
