using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_StructuralPatterns.Decorator
{
    class Client3
    {
        public string name;

        public Client3(string newName)
        {
            this.name = newName;

            ChristmasTree naturalCT = new NaturalChristmasTree();
            naturalCT = new Star(naturalCT);
            naturalCT = new Ball(naturalCT);

            string compositor = "{0}  Price {1, 10:C}";

            Console.WriteLine(string.Format(compositor,naturalCT.Name,naturalCT.GetCost()));

            ChristmasTree artificialCT = new ArtififcialChristmasTree();
            artificialCT = new Ball(artificialCT);
            
            Console.WriteLine(string.Format(compositor, artificialCT.Name, artificialCT.GetCost()));
        }
    }
}
