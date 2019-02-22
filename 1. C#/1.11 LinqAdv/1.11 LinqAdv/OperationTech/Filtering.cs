using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class Filtering
    {
        List<Technology> listT = new List<Technology>();
        
        public Filtering(List<Technology> newListT)
        {
            listT = newListT;

            foreach (Technology t in listT)
            {
                Console.WriteLine(t.company + " " + t.warranty);
            }

            var listWarr = listT.Where(x => x.warranty > 2);
            
            Console.WriteLine("Show all elements that have waranty bigger than 2:");
            ShowList(listWarr);

            var listFirst5 = listT.Take(5);

            Console.WriteLine("Show the first 5 elements:");
            ShowList(listFirst5);

            var listWithoutFirst2 = listT.Skip(2);

            Console.WriteLine("Skipe first 2 elements:");
            ShowList(listWithoutFirst2);
            
            var listCond = listT.TakeWhile(x=>x.warranty>2);
            Console.WriteLine("Show elements while warranty>2: ");
            ShowList(listCond);

            var result = listT.SkipWhile(x=>x.warranty>3);
            Console.WriteLine("Skip elements while waranty >3: ");
            ShowList(result);

            var listUnique = listT.Distinct();
            Console.WriteLine("Show unique items:");
            ShowList(listUnique);
        }

        private void ShowList(IEnumerable<Technology> lt)
        {
            foreach (Technology item in lt)
            {
                Console.WriteLine(item.company + " " + item.warranty);
            }
        }
    }
}
