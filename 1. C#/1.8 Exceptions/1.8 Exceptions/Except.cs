using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace _1._8_Exceptions
{
    class Except
    {
        public Except()
        {
            int n = -1;
            while (n != 0)
            {
                try
                {
                    Console.WriteLine("    Menu");
                    Console.WriteLine("1 - Input Arguments Exception");
                    Console.WriteLine("2 - Double Catch and Finnaly");
                    Console.WriteLine("3 - Throw example & Custom Exception");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Chose operation: ");

                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (n)
                    {
                        case 1: CheckNumbers(); break;
                        case 2: ProcessingFile(); break;
                        case 3: CheckCode(); break;
                        case 0: Console.WriteLine("Exit!"); break;
                        default: Console.WriteLine("Don't exist this operation!"); break;
                    }
                }
                catch(FormatException fEx)
                {
                    Console.WriteLine("Error! Input a number! " + fEx.Message);
                    Trace.WriteLine("Error! Input a number! " + fEx.Message);
                }
            }
        }
        
        private void CheckCode()
        {
            try
            {
                Console.Write("Code=");
                string code = Console.ReadLine();
                if (code.Length > 10)
                {
                    throw new MyException(code.Length);
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

        private void ProcessingFile()
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
            catch (Exception ex) when (fileStream != null)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        private void CheckNumbers()
        {
            char firstchar = 'a';
            char secondchar = 'b';
            try
            {
                if (firstchar.GetType() == typeof(int) && secondchar.GetType() == typeof(int))
                    Console.WriteLine(Sum(firstchar, secondchar));
                else
                    throw new ArgumentException();
            }
            catch (Exception ae)
            {
                Console.WriteLine("Exception: " + ae.Message);
                Debug.WriteLine(ae.Message);
            }
        }

        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
