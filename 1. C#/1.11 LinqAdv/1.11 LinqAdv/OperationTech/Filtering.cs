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

            var result1 = listT.Where(x => x.warranty > 2);
            
            Console.WriteLine("Show all elements that have waranty bigger than 2:");
            ShowList(result1);

            var result2 = listT.Take(5);

            Console.WriteLine("Show the first 5 elements:");
            ShowList(result2);

            var resutl3 = listT.Skip(2);

            Console.WriteLine("Skipe first 2 elements:");
            ShowList(resutl3);
            
            var result4 = listT.TakeWhile(x=>x.warranty>2);
            Console.WriteLine("Show elements while warranty>2: ");
            ShowList(result4);

            var result5 = listT.SkipWhile(x=>x.warranty>3);
            Console.WriteLine("Skip elements while waranty >3: ");
            ShowList(result5);

            var result6 = listT.Distinct();
            Console.WriteLine("Show unique items:");
            ShowList(result6);
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
