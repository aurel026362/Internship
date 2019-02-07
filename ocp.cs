using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //OCP

    class ocp
    {

        
        public virtual void move()
        {
           // To move at general
        }
    }

    class car : ocp
    {
        public override void move()
        {
            //Drive
        }
    }

    class plane : ocp
    {
        public override void move()
        {
            //Fly
        }
    }
}
