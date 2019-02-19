using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Nullable
{
    class BookEqualityComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            if (x.name.Equals(y.name) && x.code.Equals(y.code) && x.page == y.page)
                return true;
            else return false;
        }

        public int GetHashCode(Book obj)
        {
            return (obj.name + ";" + obj.code + ";" + obj.page).GetHashCode();
        }
    }
}
