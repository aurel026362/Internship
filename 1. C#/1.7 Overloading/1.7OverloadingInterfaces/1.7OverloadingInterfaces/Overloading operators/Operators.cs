using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.Overloading_operators
{
    class Operators
    {
        public int Value;
        public static bool operator ==(Operators a, Operators b)
        {
            if (a.Value == b.Value) return true;
            else return false;
        }

        public static bool operator !=(Operators a, Operators b)
        {
            if (a.Value != b.Value) return true;
            else return false;
        }
    }
}
