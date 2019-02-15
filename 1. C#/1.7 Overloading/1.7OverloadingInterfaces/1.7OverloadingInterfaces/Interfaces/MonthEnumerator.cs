using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces
{
    class MonthEnumerator : IEnumerator
    {
        string[] month;
        int position = -1;

        public MonthEnumerator(string[] month)
        {
            this.month = month;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= month.Length)
                    throw new InvalidOperationException();
                return month[position];
            }
        }

        public bool MoveNext()
        {
            if (position < month.Length - 2)
            {
                position += 2;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
