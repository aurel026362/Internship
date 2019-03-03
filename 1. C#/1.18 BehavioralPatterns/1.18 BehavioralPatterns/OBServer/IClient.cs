using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns
{
    interface IClient
    {
        void ReceiveMessage(string name, string version);
    }
}
