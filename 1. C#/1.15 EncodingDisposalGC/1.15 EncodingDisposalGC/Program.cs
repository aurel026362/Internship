using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._15_EncodingDisposalGC
{
    class Program
    {
        static void Main(string[] args)
        {
            EncodingAndWriteInFile();
            CompareStrings();
            //TimeSpanExample();
            DateTimeExample();

            Console.ReadKey();
        }

        private static void DateTimeExample()
        {
            DateTime timeNow = DateTime.Now;
            DateTime myBirthDay = new DateTime(1999, 5, 22);

            Console.WriteLine(timeNow);
            Console.WriteLine(myBirthDay);


            //DateTime IHave = timeNow - myBirthDay;

        }

        private static void TimeSpanExample()
        {
            Console.WriteLine("\n TimeSpan Example:");
            TimeSpan result = TimeSpan.FromDays(9);

            while (result.Seconds != 100)
            {
                Console.Clear();
                result = result - TimeSpan.FromSeconds(1);

                string composition = "E {0,-5} {1,-5} {2,-5} {3,-5}";

                Console.WriteLine(string.Format(composition, "D", "H", "M", "S"));
                Console.WriteLine(string.Format(composition, result.Days.ToString(), result.Hours.ToString(), result.Minutes.ToString(), result.Seconds.ToString()));
                if ((result.Seconds % 5) == 0) Console.WriteLine("\a");
                Thread.Sleep(1000);
            }
        }

        private static void EncodingAndWriteInFile()
        {
            string str = "Era odata ca niciodata";

            byte[] utf8 = Encoding.UTF8.GetBytes(str);

            foreach (byte b in utf8)
            {
                Console.Write($"{b} ");
            }

            Console.WriteLine();

            str = Encoding.UTF8.GetString(utf8);

            Console.WriteLine($"Initial string: {str}");
        }

        private static void CompareStrings()
        {
            string str1 = "Moldova";
            string str2 = "moldova";

            bool equal = str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Moldova == moldova : {equal}");
        }

        private enum StringComparision
        {
            CurrentCulture,
            CurrentCultureIgnoreCase,
            InvariantCulture,
            InvariantCultureIgnoreCase,
            Ordinal,
            OrdinalIgnoreCase
        }
    }
}
