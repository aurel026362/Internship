using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.OBServer
{
    class VipClient : IClient
    {
        string myName;
        IApplication app;

        public VipClient(string newName, IApplication application)
        {
            myName = newName;
            app = application;
            app.AddSubscriber(this);
        }

        public void ReceiveMessage(string name, string version)
        {
            Console.WriteLine($"Dear vip client - {myName}, {name} appear with new version {version}. You got +100 points!");
        }
    }
}
