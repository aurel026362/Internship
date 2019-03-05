using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID2.ISP
{
    public class SmartPhone : ICalling, IPhoto
    {
        public void Call()
        {
            Console.WriteLine("SmartPhone: The SmartPhone can to call");
        }

        public void TakePhoto()
        {
            Console.WriteLine("SmartPhone: And this can to take photo");
        }
    }
}
