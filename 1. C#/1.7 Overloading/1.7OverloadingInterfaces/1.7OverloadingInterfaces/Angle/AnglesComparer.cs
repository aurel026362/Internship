using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.Angle
{
    class AnglesComparer : IComparer<Angles>
    {
        public int Compare(Angles x, Angles y)
        {
            if (x.minutes > y.minutes)
                return 1;
            else if (x.minutes < y.minutes)
                return -1;
            else return 0;
        }
    }
}
