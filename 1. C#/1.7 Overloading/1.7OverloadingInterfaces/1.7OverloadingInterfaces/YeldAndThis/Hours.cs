using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.YeldAndThis
{
    class Hours : IEnumerable
    {
        private string[] hours = {"0 Hour", "1 Hour", "2 Hour",
            "3 Hour", "4 Hour", "5 Hour", "6 Hour", "7 Hour",
            "8 Hour", "9 Hour", "10 Hour", "11 Hour"};

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator();
            //Show only 2-th and 3-th elements
            //yield return hours[3];
            //yield return hours[2];

            //for (int i = 0; i < hours.Length; i++)
            //{
            //    yield return hours[i];
            //}
        }

        class MyEnumerator : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
