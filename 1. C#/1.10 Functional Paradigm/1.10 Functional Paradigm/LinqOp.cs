using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10_Functional_Paradigm
{
    class LinqOp
    {
        private delegate void ShowList();
        private delegate float AVGPersonsAge();
        private delegate bool ComparePerson();
        private List<Person> persons = new List<Person>();
        public LinqOp()
        {
            int n = -1;
            while (n != 0)
            {
                Console.WriteLine();
                Console.WriteLine(@"     MENIU      ");
                Console.WriteLine("1 - Delegate and Collections");
                Console.WriteLine("2 - Anonymous functions & Lambda");
                Console.WriteLine("3 - Extension method");
                Console.WriteLine("4 - Linq");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("-------------------------");
                Console.Write("Chose operation: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (n)
                {
                    case 1: DelegateOp(); break;
                    case 2: AnonymousFunct(); break;
                    case 3: ExtensionMethod(); break;
                    case 4: LinqOper(); break;
                    case 0: Console.WriteLine("Exit!"); break;
                    default: Console.WriteLine("Don't exist this operation!"); break;
                }

            }
        }

        private void LinqOper()
        {
            //Query
            var sortPersons = from sp in persons
                              where sp.age > 30
                              orderby sp.fname
                              select sp.fname + " " + sp.lname + " " + sp.age;

            Console.WriteLine("Query. Sorted persons by age: ");
            foreach (var s in sortPersons)
            {
                Console.WriteLine(s);
            }

            var somePerson = new
            {
                fname = "Lev",
                lname = "Tolstoi"
            };
            //Fluent
            var sortPersons2 = persons.
                Where((p => (p.fname.Equals(somePerson.fname)) && (p.lname.Equals(somePerson.lname)))).
            OrderBy(p => p.age).Select(p => p.fname + " " + p.lname + " " + p.age);

            Console.WriteLine("Fluent. Show persons with date: Lev Tolstoi ");
            foreach (var s2 in sortPersons2)
            {
                Console.WriteLine(s2);
            }

        }

        private void ExtensionMethod()
        {
            //Extension method
            bool fnr = persons.CheckFName("Jora");
            Console.WriteLine("Exist of name 'Jora' : " + fnr);
        }

        private void AnonymousFunct()
        {
            //Anonymous
            AVGPersonsAge AvgAge = delegate ()
            {
                int s = 0;
                int nr = 0;
                foreach (Person pp in persons)
                {
                    s += pp.age;
                    nr++;
                }
                float avg = s / nr;
                return avg;
            };

            //Lambda
            AvgAge = () => {
                int s = 0;
                int nr = 0;
                foreach (Person pp in persons)
                {
                    s += pp.age;
                    nr++;
                }
                float avg = s / nr;
                return avg;
            };

            //Anonymous is equivalent with Lambda
            Console.WriteLine("AVG(Ages) is " + AvgAge());
        }

        private void DelegateOp()
        {

            ShowList showList = InitializeList;

            showList += ShowDataList;

            showList?.Invoke();
        }

        private void InitializeList()
        {
            Console.WriteLine("Initializing List!");
            persons.Clear();
            persons.AddRange(new List<Person> {
                new Person { fname = "Mihai", lname = "Juravliov" , age =43},
                new Person { fname = "Ecaterina", lname = "Mihalcova", age = 23 },
                new Person { fname = "Jora", lname = "Litvin", age = 35 },
                new Person { fname = "Lev", lname = "Tolstoi", age = 42 },
                new Person { fname = "Oleg", lname = "Norvec", age = 27 }}
                );
        }

        private void ShowDataList()
        {
            Console.WriteLine("\nList of persons: ");
            foreach (Person p in persons)
            {
                Console.WriteLine(p.fname + " " + p.lname + " " + p.age);
            }
            Console.WriteLine();
        }
    }
}
