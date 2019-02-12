using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Tester : Worker
    {
        readonly private int t = 10;
        public Tester(string name, string function) : base(name, function)
        {

        }

        public override void Work()
        {

        }
    }

    //class A
    //{
    //    int a;
    //    public virtual void Move()
    //    {

    //    }
    //}

    //class B : A
    //{
    //    public sealed override void Move()
    //    {
    //        //asdsadsa
    //    }
    //}

    //class C : B
    //{
    //    public C()
    //    {
    //        Move();
    //    }
    //}

}
