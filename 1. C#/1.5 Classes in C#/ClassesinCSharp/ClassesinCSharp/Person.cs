using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine("Person is moving");
        }

        public void Move(string address)
        {
            Console.WriteLine("Person go to the address " + address);
        }
    }
}
