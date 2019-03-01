using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    class Star : ChristmasTreeDecorator
    {
        public Star(ChristmasTree ct) : base(ct.Name + " with Star",ct)
        {

        }

        public override int GetCost()
        {
            return tree.GetCost() + 100;
        }
    }
}
