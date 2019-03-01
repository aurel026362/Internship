using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Proxy
{
    interface IListneningMusics
    {
        void Play();
        void Pause();
        void NextSound();
        void PreviousSound();
    }
}
