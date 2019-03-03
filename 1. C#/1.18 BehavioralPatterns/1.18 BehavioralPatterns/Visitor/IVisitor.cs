using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    interface IVisitor
    {
        void Visit(MyDataBase myDB);
        void Visit(Files secretFiles);
    }
}
