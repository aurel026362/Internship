using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.YeldAndThis
{
    class Week : IEnumerable
    {
        private string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

        public string this[int key]
        {
            get
            {
                if (key < days.Length && key > -1)
                    return days[key];
                else throw new IndexOutOfRangeException();
            }

        }

        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
}
