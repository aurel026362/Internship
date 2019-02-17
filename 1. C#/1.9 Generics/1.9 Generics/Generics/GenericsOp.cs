using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Generics
{
    class GenericsOp
    {
        PersonOp<Student> students;

        public GenericsOp()
        {
            SampleOperation<int> variable = new SampleOperation<int>();
            int a = variable.Atribute(2);

            Console.WriteLine("Generic. Int Atribute: " + a);

            SampleOperation<float> variable2 = new SampleOperation<float>();
            float f = variable2.Atribute(2.22f);

            Console.WriteLine("Generic. Float Atribute: " + f);

            students = new PersonOp<Student>();
            Student[] sts = new Student[] { new Student { name = "Ion", age = 12 },
                new Student { name = "irina", age = 13 } };
            students.ReplaceAll(sts, 2);

            Console.WriteLine("Initial list:");
            Show(students, 2);

            students.persons[1].name = "Aleona";
            students.persons[1].age = 11;

            Console.WriteLine("\n Modificated list:");
            Show(students, 2);
        }

        private void Show(PersonOp<Student> st, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(st.persons[i].name + " " + st.persons[i].age);
            }
        }
    }
}
