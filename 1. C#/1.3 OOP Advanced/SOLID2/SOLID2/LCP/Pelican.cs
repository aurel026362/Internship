using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID2.LCP
{
    public class Pelican : IFlying, ISwimming
    {
        public void Fly()
        {
            Console.WriteLine("Pelican fly");
        }

        public void Swim()
        {
            Console.WriteLine("Pelican Swim");
        }
    }
}
