using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    class Files : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
