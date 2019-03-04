using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._19_ioCDI
{
    class Person
    {
        IRead action;

        public Person(IRead newRead)
        {
            action = newRead;
        }

        public void Read()
        {
            action.Read();
        }
    }
}
