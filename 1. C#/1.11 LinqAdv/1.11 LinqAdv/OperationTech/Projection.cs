using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class Projection
    {
        List<PC> listT = new List<PC>();

        public Projection(List<PC> newList)
        {
            listT = newList;
            //sample select
            var result = listT.Select(x => (x.company + " " + x.warranty));

            foreach(string item in result)
            {
                Console.WriteLine(item);
            }

            //select many
            var result1 = listT.SelectMany(x => x.listH).Reverse();
            Console.WriteLine("Show all hardware elements:");
            ShowData(result1);

            var res = listT.SelectMany(x => x.listH, (parent, child) => new { parent.company, child.name}).OrderByDescending(x => x.company).ThenBy(x => x.name);
            Console.WriteLine("Show Select Many:");
            foreach (var item in res)
            {
                Console.WriteLine(item.company + " " + item.name);
            }
        }

        private void ShowData(IEnumerable<Hardware> res)
        {
            foreach (Hardware item in res)
            {
                Console.WriteLine(item.type + " " + item.name);
            }
        }
    }
}
