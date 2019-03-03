using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns
{
    class Application : IApplication
    {
        public string name;
        public string version;

        List<IClient> clients;

        public Application(string newName, string newVersion)
        {
            name = newName;
            version = newVersion;

            clients = new List<IClient>();
        }

        public void AddSubscriber(IClient client)
        {
            clients.Add(client);
        }

        public void RemoveSubscriber(IClient client)
        {
            clients.Remove(client);
        }

        public void Notify()
        {
            foreach (var client in clients)
            {
                client.ReceiveMessage(name, version);
            }
        }
    }
}
