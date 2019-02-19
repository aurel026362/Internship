using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class TechnologyOp
    {
        List<Technology> listT = new List<Technology>();
        List<PC> listPc = new List<PC>();


        public TechnologyOp()
        {
            listT.AddRange(new List<Technology>
            {
                new PC{ company = "Acer", warranty = 2 },
                new PC{ company = "Lenovo", warranty = 3 },
                new SmartPhone{ company = "Xiaomi", warranty = 5},
                new PC{ company = "Dell", warranty = 6 },
                new SmartPhone{ company = "Samsung", warranty = 4},
                new SmartPhone{ company = "IPhone", warranty = 3},
                new PC{ company = "Asus", warranty = 4 },
            }
            );

            var result1 = listT.Where(x => x.warranty > 2).Select(x => x.company + " " + x.warranty);

            foreach (Technology t in result1)
            {
                Console.WriteLine(t);
            }
        }
    }
}
