using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_BehavioralPatterns.Visitor
{
    class Administrator
    {
        List<IElement> clients = new List<IElement>();

        public void AddElement(IElement client)
        {
            clients.Add(client);
        }

        public void RemoveElement(IElement client)
        {
            clients.Remove(client);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement client in clients)
            {
                client.Accept(visitor);
            }
        }
    }
}
