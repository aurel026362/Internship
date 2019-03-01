using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Proxy
{
    class iPhone : IMusicGadget, ICallable
    {
        public void Call(string to)
        {
            Console.WriteLine($"IPhone. I call to {to}");
        }

        public void NextSound()
        {
            Console.WriteLine($"IPhone. Next sound!");
        }

        public void Pause()
        {
            Console.WriteLine($"IPhone. Pause the music!");
        }

        public void Play()
        {
            Console.WriteLine($"IPhone. Play the music");
        }

        public void PreviousSound()
        {
            Console.WriteLine($"IPhone. Previous sound!");
        }

        public void TurnOff()
        {
            Console.WriteLine($"IPhone. Turn Off IPhone!");
        }

        public void TurnOn()
        {
            Console.WriteLine($"IPhone. Turn On IPhone!");
        }
    }
}
