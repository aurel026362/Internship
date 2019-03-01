using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    class Ball : ChristmasTreeDecorator
    {
        public Ball(ChristmasTree ct) : base(ct.Name + " with Ball", ct)
        {

        }

        public override int GetCost()
        {
            return tree.GetCost() + 20;
        }
    }
}
