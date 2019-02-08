using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    //OCP

    class OCP
    {

        
        public virtual void Move()
        {
           // To move at general
        }
    }

    class Car : OCP
    {
        public override void Move()
        {
            //Drive
        }
    }

    class Plane : OCP
    {
        public override void Move()
        {
            //Fly
        }
    }
}
