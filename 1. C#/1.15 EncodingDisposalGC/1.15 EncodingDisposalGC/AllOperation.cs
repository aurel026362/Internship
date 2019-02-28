using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._15_EncodingDisposalGC
{
    class AllOperation
    {
        private enum StringComparision
        {
            CurrentCulture,
            CurrentCultureIgnoreCase,
            InvariantCulture,
            InvariantCultureIgnoreCase,
            Ordinal,
            OrdinalIgnoreCase
        }

        public AllOperation()
        {
            EncodingAndWriteInFile();
            CompareStrings();
            //TimeSpanExample();
            DateTimeExample();
            DateTimeOfSetExample();
            TimeZoneExample();
            FormatInfoExample();
            FileStreamExample();
        }

        ~AllOperation()
        {
            Console.WriteLine("\n Object 'AllOperation' destroyed!");
        }

        private void FileStreamExample()
        {
            Console.WriteLine("\nFile Stream Example: ");
            Console.WriteLine("File 'text.txt' contains: ");

            using (StreamReader fs = new StreamReader("text.txt"))
            {
                StringBuilder sb = new StringBuilder();
                Console.WriteLine(fs.ReadToEnd());
            }
        }

        private void FormatInfoExample()
        {
            Console.WriteLine("\nFormat Info Example: ");

            DateTime dt = new DateTime(2019, 5, 22, 19, 20, 24);

            CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
            Console.WriteLine(240.ToString("C", uk));

            CultureInfo invariant = CultureInfo.InvariantCulture;
            uk = new CultureInfo("en-GB");

            Console.WriteLine("INVARIANT: " + dt.ToString(invariant));
            Console.WriteLine("EN-GB: " + dt.ToString(uk));

            Console.WriteLine("Number Format:");

            NumberFormatInfo nf = new NumberFormatInfo();
            nf.NumberGroupSeparator = " ";

            Console.WriteLine(123.456.ToString("N1", nf));
            Console.WriteLine(123.456.ToString("N3", nf));
            Console.WriteLine(123.456.ToString("N4", nf));
        }

        private void TimeZoneExample()
        {
            Console.WriteLine("\nTime Zone Example:");

            TimeZone currentZone = TimeZone.CurrentTimeZone;

            Console.WriteLine(currentZone.StandardName + " || " + currentZone.DaylightName);

            DateTime dt1 = new DateTime(2008, 1, 1);
            DateTime dt2 = new DateTime(2010, 5, 22);

            Console.WriteLine("IS DAYlight Saving Time:");
            Console.WriteLine(currentZone.IsDaylightSavingTime(dt1));
            Console.WriteLine(currentZone.IsDaylightSavingTime(dt2));

            Console.WriteLine("Current Zone...");
            Console.WriteLine(dt1 + "  ---  " + currentZone.GetUtcOffset(dt1));
            Console.WriteLine(dt2 + "  ---  " + currentZone.GetUtcOffset(dt2));
        }

        private void DateTimeOfSetExample()
        {
            Console.WriteLine("\nDate Time Of Set Example: ");

            DateTime now = DateTime.Now;
            DateTimeOffset moldova = DateTimeOffset.Now;
            DateTimeOffset ucraina;

            DateTime localDateTime = DateTime.SpecifyKind(now, DateTimeKind.Local);
            DateTime utcDateTime = DateTime.SpecifyKind(now, DateTimeKind.Utc);
            DateTime UnspDateTime = DateTime.SpecifyKind(now, DateTimeKind.Unspecified);

            Console.WriteLine($"Local time: {localDateTime}");
            Console.WriteLine($"UTC time: {utcDateTime}");
            Console.WriteLine($"Unspecified: {UnspDateTime}");

            Console.WriteLine($"Moldova time: {moldova}");
        }

        private void DateTimeExample()
        {
            Console.WriteLine("\nDate Time Example:");
            DateTime timeNow = DateTime.Now;
            TimeSpan years = new TimeSpan(7185, 5, 22, 0, 0);

            DateTime IHave = timeNow.Subtract(years);
            Console.WriteLine("First : " + IHave);
        }

        private void TimeSpanExample()
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

        private void EncodingAndWriteInFile()
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

        private void CompareStrings()
        {
            string str1 = "Moldova";
            string str2 = "moldova";

            bool equal = str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Moldova == moldova : {equal}");
        }
    }
}
