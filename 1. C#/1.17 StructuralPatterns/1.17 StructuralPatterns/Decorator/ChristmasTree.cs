using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    abstract class ChristmasTree
    {
        public string Name { get; protected set; }

        public ChristmasTree(string newname)
        {
            this.Name = newname;
        }

        public abstract int GetCost();
    }
}
