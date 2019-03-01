using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    abstract class ChristmasTreeDecorator:ChristmasTree
    {
        protected ChristmasTree tree;

        public ChristmasTreeDecorator(string name, ChristmasTree newTech) : base(name)
        {
            this.tree = newTech;
        }
    }
}
