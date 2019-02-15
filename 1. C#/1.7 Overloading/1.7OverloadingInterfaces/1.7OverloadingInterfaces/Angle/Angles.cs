using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OverloadingInterfaces.Angle
{
    class Angles:IComparable
    {
        public int degrees, minutes, seconds;

        public Angles(int degrees, int minutes, int seconds)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Angles()
        {

        }
        
        public Angles Sum(Angles[] a)
        {
            Angles c = new Angles();
            foreach (Angles s in a)
            {
                c.degrees += s.degrees;
                c.minutes += s.minutes;
                c.seconds += s.seconds;
            }

            if (c.seconds >= 60)
            {
                int rez = c.seconds % 60;
                int dec = c.seconds / 60;
                c.minutes += dec;
                c.seconds = rez;
            }

            if (c.minutes >= 60)
            {
                int rez = c.minutes % 60;
                int dec = c.minutes / 60;
                c.degrees += dec;
                c.minutes = rez;
            }

            if (c.degrees>=360)
            {
                int rez = c.degrees % 360;
                c.degrees = rez;
            }
            return c;
        }

        public int CompareTo(object obj)
        {
            Angles ob = (Angles)obj;
            //if (ob != null)
                return this.seconds.CompareTo(ob.seconds);
            //else throw new Exception("Exception");
        }
    }
}
