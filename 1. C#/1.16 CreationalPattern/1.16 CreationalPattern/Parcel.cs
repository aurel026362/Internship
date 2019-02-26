using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16_CreationalPattern
{
    class Parcel
    {
        public float weight;
        public float size;
        public bool fragil;
        public string adress;

        public Parcel(float newWeight, float newSize, bool newFragil, string newAdress)
        {
            this.weight = newWeight;
            this.size = newSize;
            this.fragil = newFragil;
            this.adress = newAdress;
        }
    }
}
