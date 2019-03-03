using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns
{
    interface IApplication
    {
        void AddSubscriber(IClient client);
        void RemoveSubscriber(IClient client);
        void Notify();
    }
}
