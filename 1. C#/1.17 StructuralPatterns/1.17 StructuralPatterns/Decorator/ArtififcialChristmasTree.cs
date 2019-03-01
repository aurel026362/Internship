using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    class ArtififcialChristmasTree : ChristmasTree
    {
        public ArtififcialChristmasTree() : base("Artififcial Christmas Tree")
        {

        }

        public override int GetCost()
        {
            return 870;
        }
    }
}
