using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    class NaturalChristmasTree:ChristmasTree
    {
        public NaturalChristmasTree():base("Natural Christmas Tree")
        {
        }

        public override int GetCost()
        {
            return 230;
        }
    }
}
