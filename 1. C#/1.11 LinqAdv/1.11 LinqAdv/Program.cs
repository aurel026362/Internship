using System;
using _1._11_LinqAdv.OperationTech;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<PC> listPC = new List<PC>();
            listPC.AddRange(new List<PC>
            {
                new PC{ company = "Acer", warranty = 2, listH = new List<Hardware>{
                    new Hardware { type = "motherboard", name = "asus moth"},
                    new Hardware { type = "cpu", name = "amd fx"},
                    new Hardware { type = "gpu", name = "geForce 990"}
                    }
                },
                new PC{ company = "Lenovo", warranty = 3, listH = new List<Hardware>{
                    new Hardware { type = "powersupply", name = "fr-432"}
                    }
                },
                new PC{ company = "Dell", warranty = 6, listH = new List<Hardware>{
                    new Hardware { type = "ram", name = "kingstone"}
                    }
                },
                new PC{ company = "Asus", warranty = 4 , listH = new List<Hardware>{
                    new Hardware { type = "rom", name = "samsung" },
                    new Hardware { type = "cpu", name = "intel" }
                    }
                }
            }
           );

            List<Technology> listT = new List<Technology>();
            listT.AddRange(new List<Technology>
            {
                new PC{ company = "Acer", warranty = 2 },
                new PC{ company = "Lenovo", warranty = 3 },
                new SmartPhone{ company = "Xiaomi", warranty = 5},
                new PC{ company = "Dell", warranty = 6 },
                new SmartPhone{ company = "Samsung", warranty = 4},
                new SmartPhone{ company = "IPhone", warranty = 3},
                new PC{ company = "Asus", warranty = 4 },
                new PC{ company = "Dell", warranty = 2 },
                new SmartPhone { company = "Xiaomi", warranty = 2 },
                new SmartPhone { company = "Xiaomi", warranty = 7 }
            }
            );

            int n = -1;
            while ( n!=0 )
            {
                Console.WriteLine("   Menu");
                Console.WriteLine("1 - Filtering");
                Console.WriteLine("2 - Projection");
                Console.WriteLine("3 - Joining");
                Console.WriteLine("4 - Grouping");
                Console.WriteLine("5 - Clausures Operation");
                Console.WriteLine("6 - Operation with Default FunctionDel...");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("---------------");
                Console.Write("Chose operation:");

                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch ( n )
                {
                    case 1: new Filtering(listT); break;
                    case 2: new Projection(listPC); break;
                    case 3: new Joining(); break;
                    case 4: new Grouping(listT); break;
                    case 5: new ClausuresOp(); break;
                    case 6: new DefaultDel(); break;
                    case 0: Console.WriteLine("Exit!"); break;
                    default:break;
                }
            }

            Console.ReadKey();
        }
    }
}
