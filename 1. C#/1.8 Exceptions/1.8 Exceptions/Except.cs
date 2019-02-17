using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Exceptions
{
    class Except
    {
        public Except()
        {
            int n = -1;
            while (n != 0)
            {
                    Console.WriteLine("1 - Input Arguments Exception");
                    Console.WriteLine("2 - Double Catch and Finnaly");
                    Console.WriteLine("3 - Throw example & Custom Exception");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Chose operation: ");

                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1: InputExc(); break;
                        case 2: DoubleCatchFinally(); break;
                        case 3: ThrowEx(); break;
                        case 0: Console.WriteLine("Exit!"); break;
                        default: Console.WriteLine("Don't exist this operation!"); break;
                    }
            }

        }
        
        private void ThrowEx()
        {
            try
            {
                Console.Write("s=");
                string s = Console.ReadLine();
                if (s.Length > 10)
                {
                    throw new MyException(s.Length);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Done!");
            }
        }

        private void DoubleCatchFinally()
        {
            string text;
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException fileEx)
            {
                Console.WriteLine(fileEx.Message);
            }
            catch (Exception ex) when (fileStream == null)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        private void InputExc()
        {
            char a = 'a';
            char b = 'b';
            try
            {
                if (a.GetType() == typeof(int) && b.GetType() == typeof(int))
                    InputExcMethod('a', 'b');
                else
                    throw new ArgumentException();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Argument exception: " + ae.Message);
                throw new ArgumentException();
            }
        }

        private void InputExcMethod(int a, int b)
        {
            Console.WriteLine("It's 2 number is " + a + " and " +b);
        }
    }
}
