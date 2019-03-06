using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Generics
{
    class SampleOperation<T> where T: struct 
    {
        T c;
        public T Atribute(T a)
        {
                c = a;
            return c;
        }
    }
}
