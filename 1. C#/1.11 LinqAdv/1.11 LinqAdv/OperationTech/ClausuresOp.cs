using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class ClausuresOp
    {
        delegate int CoubEx(int number);
        public ClausuresOp()
        {
            Console.WriteLine("Closures with Func: ");
            var de = Coub();
            Console.WriteLine(de(4));
            Console.WriteLine(de(4));
            Console.WriteLine(de(4));

            Console.WriteLine("\nClosures with sample delegate: ");

            var res = Example();
            Console.WriteLine(res(2));
            Console.WriteLine(res(3));
            Console.WriteLine(res(5));

        }


        private CoubEx Example()
        {
            int exp = 2;
            CoubEx ce = delegate (int var2)
            {
                var2 = var2 * exp;
                exp++;
                return var2;
            };
            return ce;
        }

        private Func<int, int> Coub()
        {
            int nr = 1;
            Func<int, int> inc = delegate (int a2) {
                    nr++;
                int res = nr + a2;
                return (res);
            };
            return inc;
        }

    }
}
