using _1._11_LinqAdv.OperationTech.JoiningOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class Joining
    {

        public Joining()
        {
            List<Student> listS = new List<Student>();

            var st1 = new Student { name = "Aleona", age = 17 };
            var st2 = new Student { name = "Irina", age = 16 };
            var st3 = new Student { name = "Ionel", age = 17 };

            listS.AddRange( new List<Student> { st1, st2, st3});

            List<StudentsNotes> listN = new List<StudentsNotes>();

            var studentn1 = new StudentsNotes { disc = 6, owner = st1 };
            var studentn2 = new StudentsNotes { disc = 8, owner = st2 };
            var studentn3 = new StudentsNotes { disc = 9, owner = st2 };
            var studentn4 = new StudentsNotes { disc = 6, owner = st1 };
            var studentn5 = new StudentsNotes { disc = 7, owner = st3 };
            var studentn6 = new StudentsNotes { disc = 5, owner = st1 };

            listN.AddRange( new List<StudentsNotes> { studentn1, studentn2, studentn3, studentn4, studentn5, studentn6 });

            var query = listS.Join(listN, Student => Student, StudentNotes => StudentNotes.owner,
                (Student, StudentsNotes) => new {
                    ownerName = Student.name, noter = StudentsNotes.disc
                });

            Console.WriteLine("Show joined elements:");
            Console.WriteLine($"Name:   Note:");
            foreach (var item in query)
            {
                Console.WriteLine(item.ownerName + " : " + item.noter);
            }
        }
    }
}
