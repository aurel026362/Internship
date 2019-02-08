﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{

    //ISP

    public interface ICalling{
        void Call();
    }

    public interface IPhoto
    {
        void TakePhoto();
    }

    public class Landline:ICalling
    {
        public void Call()
        {
            Console.WriteLine("Possible to call, but don't take a photo");
        }
    }

    public class SmartPhone:ICalling, IPhoto
    {
        public void Call()
        {
            Console.WriteLine("The SmartPhone can to call");
        }

        public void TakePhoto()
        {
            Console.WriteLine("And this can to take photo");
        }
    }

    class ISP
    {
        Landline landLine = new Landline();
        SmartPhone smartPhone = new SmartPhone();
    }
}