using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Generics
{
    internal class PersonOp<T> where T : class//, IEnumerable
    {
        public T[] persons { get; set; }

        public T this [int k]
        {
            get
            {
                return persons[k];
            }
            set
            {
                this[k] = value;
            }
        }

        public PersonOp()
        {

        }

        internal void ReplaceAll(T[] newPersons, int n)
        {
            persons = new T[n];
            persons = newPersons;
        }


        /*public void Modification(T newT, int i)
        {
            st[i] = newT;
        }*/
    }
}
