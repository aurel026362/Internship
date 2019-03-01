using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Proxy
{
    class iPod : IMusicGadget
    {
        iPhone iphone;

        public iPod()
        {
            if (iphone == null)
                iphone = new iPhone();
        }

        public void NextSound()
        {
            iphone.NextSound();
        }

        public void Pause()
        {
            iphone.Pause();
        }

        public void Play()
        {
            iphone.Play();
        }

        public void PreviousSound()
        {
            iphone.PreviousSound();
        }

        public void TurnOff()
        {
            iphone.TurnOff();
        }

        public void TurnOn()
        {
            iphone.TurnOn();
        }
    }
}
