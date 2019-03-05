using SOLID2.ISP;
using SOLID2.LCP;
using SOLID2.OCP;
using System;
using System.Collections.Generic;

namespace SOLID2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISP
            Console.WriteLine("\n-------ISP-----------\n");
            Landline landline = new Landline();
            landline.Call();

            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Call();
            smartPhone.TakePhoto();

            //LCP
            Console.WriteLine("\n-------LCP-----------\n");
            List<IRunning> runners = new List<IRunning>()
            {
                new Human(),
                new Horse()
            };

            Console.WriteLine("Running...");
            foreach (var runner in runners)
            {
                runner.Run();
            }

            //OCP
            Console.WriteLine("\n-------OCP-----------\n");
            Transport car = new Car();
            car.Move();

            Transport plane = new Plane();
            plane.Move();

            Console.ReadKey();
        }
    }
}
