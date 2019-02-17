using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Exceptions
{
    class MyException:Exception
    {
        public MyException(int nr) : base("Error. This string contains more 10 symbols. " +
                "It contain " + nr + " symbols!")
        {
        }
        
    }
}
