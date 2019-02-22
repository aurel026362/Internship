using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class Grouping
    {
        List<Technology> listT = new List<Technology>();
        
        public Grouping(List<Technology> newlistT)
        {
            listT = newlistT;

            var res = listT.GroupBy(x => x.company).Select(x => new
            {
                Name = x.Key,
                Count = x.Count()
            });

            Console.WriteLine("\nShow every elements and how much exist: ");
            Console.WriteLine("Name  Count");
            foreach(var technology in res)
            {
                Console.WriteLine(technology.Name + " " + technology.Count + " ");
            }

            var result1 = listT.OfType<PC>();

            Console.WriteLine("\nShow all PC: ");
            foreach (var item in result1)
            {
                Console.WriteLine(item.company + " " + item.warranty);
            }

            var result2 = listT.FirstOrDefault();
            
            Console.WriteLine("\nShow first or default element: \n" + result2.company + " " + result2.warranty);

            var result3 = listT.Any(x => x.warranty > 5);
            Console.WriteLine("\nExist element that warranty have bigger than 5 : " + result3);

            int[] a = { 1, 2, 3, 4 };
            var result4 = a.DefaultIfEmpty();

            Console.WriteLine("\nDefaultEmpty: ");
            foreach (var item in result4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            IEnumerable<int> numbers = Enumerable.Range(1,10);

            Console.WriteLine("Set of numbers:");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            IEnumerable<Technology> tt = Enumerable.Repeat(listT[0], 2);

            Console.WriteLine("Show 2 times listT[0]: ");
            foreach (Technology i in tt)
            {
                Console.WriteLine(i.company + " " + i.warranty);
            }

            Console.WriteLine();
        }
    }
}
