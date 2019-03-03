using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns
{
    class Client : IClient
    {
        public string myName;

        IApplication app;

        public Client(string newName, IApplication application)
        {
            myName = newName;
            app = application;
            app.AddSubscriber(this);
        }

        public void ReceiveMessage(string name, string version)
        {
            Console.WriteLine($"Dear {myName}, {name} appear with new version {version}.");
        }
    }
}
