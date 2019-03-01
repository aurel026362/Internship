using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Proxy
{
    class Client
    {
        public string name;
        public Client(string newName)
        {
            this.name = newName;

            IMusicGadget subject = new iPod();

            subject.TurnOn();
            subject.Play();
            subject.NextSound();
            subject.PreviousSound();
            subject.Pause();
            subject.TurnOff();
        }
    }
}
