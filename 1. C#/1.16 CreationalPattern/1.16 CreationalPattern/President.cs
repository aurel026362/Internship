using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16_CreationalPattern
{
    class President
    {
        private static Lazy<President> lazy = new Lazy<President>(() => new President(), true);
        public string name;
        public static President Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private President()
        {

        }
    }
}
