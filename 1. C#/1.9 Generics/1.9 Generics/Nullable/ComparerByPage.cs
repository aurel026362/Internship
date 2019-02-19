using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Nullable
{
    class ComparerByPage : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.page > y.page)
            {
                return 1;
            }
            else if (x.page == y.page)
                return 0;
            else return -1;
        }
    }
}
