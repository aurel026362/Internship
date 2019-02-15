using _1._7OverloadingInterfaces.Overloading_operators;
using _1._7OverloadingInterfaces.Angle;
using System.Linq;
using static System.Convert;
using static System.Console;
using static System.Array;
using _1._7OverloadingInterfaces.Interfaces;
using _1._7OverloadingInterfaces.YeldAndThis;

namespace _1._7OverloadingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            while (n != 0)
            {
                WriteLine();
                WriteLine(@"     MENIU      ");
                WriteLine("1 - Overloading operators");
                WriteLine("2 - IEnumerator & IEnumarable");
                WriteLine("3 - Angle & Sorting");
                WriteLine("4 - This[] & Yield Return");
                WriteLine("-------------------------");
                Write("Chose operation: ");
                n = ToInt32(ReadLine());

                switch (n)
                {
                    case 1: Oper(); break;
                    case 2: MonthF(); break;
                    case 3: AngleOp(); break;
                    case 4: YieldAndThisOp(); break;
                    default: WriteLine("Don't exist this operation!"); break;
                }

            }

            ReadKey();
        }

        static void MonthF()
        {
            MonthOp mo = new MonthOp();
        }

        static void Oper()
        {
            Operators a = new Operators { Value = 23 };
            Operators b = new Operators { Value = 23 };
            Operators e = new Operators { Value = 12 };

            bool c = (a == b);
            WriteLine("23 == 23 is " + c);

            bool d = (a != e);
            WriteLine("23 != 12 is " + d);

            d = (a != a);
            WriteLine("23 != 23 is " + d);
        }

        static void AngleOp()
        {
            //Initializing
            Angles[] a = new Angles[] {new Angles(359, 51, 23), new Angles(0,0,1000), new Angles(5, 20, 10), new Angles(3, 40, 50)};

            //Sorting Angles by degrees
            var b = a.OrderBy(x => x.degrees).ToList();

            //Show data sorted by degrees
            WriteLine("Sorting Angles by degrees:");
            foreach(Angles w in b)
            {
                WriteLine(w.degrees + "* " + w.minutes + "' " + w.seconds + "''");
            }
            
            //IComparable example(CompareTo)
            Sort(a);
            
            WriteLine("Sorting Angles by seconds:");
            foreach (Angles w in a)
            {
                WriteLine(w.degrees + "* " + w.minutes + "' " + w.seconds + "''");
            }

            //IComparer example (Comparer)
            Sort(a, new AnglesComparer());

            WriteLine("Sorting Angles by minutes:");
            foreach (Angles w in a)
            {
                WriteLine(w.degrees + "* " + w.minutes + "' " + w.seconds + "''");
            }

            //Show Sum of degrees, minutes and seconds
            Angles c = new Angles();
            c = c.Sum(a);

            WriteLine();
            WriteLine(c.degrees+"* "+c.minutes+"' "+c.seconds+"'' ");
        }
        
        static void YieldAndThisOp()
        {
            Week week = new Week();
            foreach (var day in week)
            {
                WriteLine(day);
            }

            //This will be show 3-th day of week(Wednesday)
            WriteLine("\n Operator this(Show 3-th day of Week): " + week[2]);

            WriteLine("\n Yeld Return example :");

            Hours hours = new Hours();
            foreach (var h in hours)
            {
                WriteLine(h);
            }

            WriteLine();
        }
    }
}
