using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.Interfaces
{
    class Month
    {
        string[] month = { "January", "February", "Marth", "Appril",
            "May", "June", "Jule", "August",
            "September", "October", "November", "December" };

        public IEnumerator GetEnumerator()
        {
            return new MonthEnumerator(month);
        }
    }
}
