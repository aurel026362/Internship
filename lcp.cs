using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //ICP

    public interface IFlying{
         void Fly();
    }

    public interface ISwimming
    {
        void Swim();
    }

    public interface IRunning
    {
        void Run();
    }

    public class Horse : IRunning
    {
        public void Run()
        {

        }
    }

    public class Human : IRunning, ISwimming
    {
        public void Run()
        {
            Console.WriteLine("Human run");
        }

        public void Swim()
        {
            Console.WriteLine("Human swim");
        }
    }

    public class Pelican:IFlying, ISwimming
    {
        public void Fly()
        {
            Console.WriteLine("Pelican fly");
        }

        public void Swim()
        {
            Console.WriteLine("Pelican Swim");
        }
    }

    class lcp
    {
        Pelican pelican = new Pelican();
        Human human = new Human();
        Horse horse = new Horse();
    }
}
