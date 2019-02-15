using SOLID2.ISP;
using SOLID2.LCP;
using SOLID2.OCP;
using System;

namespace SOLID2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISP
            Landline landline = new Landline();
            landline.Call();

            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Call();
            smartPhone.TakePhoto();

            //LCP
            Horse horse = new Horse();
            horse.Run();

            Pelican pelican = new Pelican();
            pelican.Fly();
            pelican.Swim();

            //OCP
            Transport car = new Car();
            car.Move();

            Transport plane = new Plane();
            plane.Move();

            Console.ReadKey();
        }
    }
}
