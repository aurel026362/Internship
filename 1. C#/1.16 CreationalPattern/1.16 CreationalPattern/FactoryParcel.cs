using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16_CreationalPattern
{
    class FactoryParcel
    {
        public static Parcel FragilParcel(float weight, float size, string adress)
        {
            if (CheckArguments(weight, size, adress))
            {
                var fragilParcel = new Parcel(weight, size, true, adress);
                return fragilParcel;
            }
            else
                return null;
        }

        public static Parcel SimpleParcel(float weight, float size, string adress)
        {
            if (CheckArguments(weight, size, adress))
            {
                var fragilParcel = new Parcel(weight, size, false, adress);
                return fragilParcel;
            }
            else
                return null;
        }

        public static bool CheckArguments(float weight, float size, string adress)
        {
            if (weight > 0 && size > 0 && !String.IsNullOrEmpty(adress))
            {
                return true;
            }
            return false;
        }
    }
}
