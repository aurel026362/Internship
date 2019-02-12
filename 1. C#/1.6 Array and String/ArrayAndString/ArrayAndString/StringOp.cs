using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString
{
    class StringOp
    {
        public StringOp()
        {
            StringBuilder str = Create();
            
            OperationWithString(str);
        }

        private StringBuilder Create()
        {
            StringBuilder str = new StringBuilder("mouse");
            return str;
        }

        private void OperationWithString(StringBuilder st)
        {

            Console.WriteLine();
            Console.WriteLine("Initial word: " + st);
            Console.WriteLine("Append st with 'dev': " + st.Append("dev"));
            Console.WriteLine("Insert 'ex' after 'v': " + st.Insert(6, "ex"));
            Console.WriteLine("Replace 'ex' with 'xe': " + st.Replace("ex","xe"));
            Console.WriteLine("Remove 2 symbol from 5-th element: " + st.Remove(5,2));
            Console.WriteLine();
        }
    }
}
