using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID2.OCP
{
    class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Car - drive");
        }
    }
}
