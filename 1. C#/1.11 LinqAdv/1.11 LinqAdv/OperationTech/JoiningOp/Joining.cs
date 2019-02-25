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
            List<Student> students = new List<Student>();

            var st1 = new Student { name = "Aleona", age = 17 };
            var st2 = new Student { name = "Irina", age = 16 };
            var st3 = new Student { name = "Ionel", age = 17 };

            students.AddRange( new List<Student> { st1, st2, st3});

            List<StudentsNotes> notes = new List<StudentsNotes>();

            var studentn1 = new StudentsNotes { note = 6, owner = st1 };
            var studentn2 = new StudentsNotes { note = 8, owner = st2 };
            var studentn3 = new StudentsNotes { note = 9, owner = st2 };
            var studentn4 = new StudentsNotes { note = 6, owner = st1 };
            var studentn5 = new StudentsNotes { note = 7, owner = st3 };
            var studentn6 = new StudentsNotes { note = 5, owner = st1 };

            notes.AddRange( new List<StudentsNotes> { studentn1, studentn2, studentn3, studentn4, studentn5, studentn6 });

            var query = students.Join(notes, Student => Student, StudentNotes => StudentNotes.owner,
                (student, note) => new
                {
                    ownerName = student.name,
                    noter = note.note
                }).GroupBy(x => x.ownerName).Select(x => new
                {
                    ownerName = x.Key,
                    noter = x.Select(n => n.noter)
                });

            Console.WriteLine("Show joined elements:");
            foreach (var student in query)
            {
                Console.WriteLine(student.ownerName );
                foreach(var note in student.noter)
                {
                    Console.Write(note + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Group Join: ");

            var result = students.GroupJoin(notes,
                Student => Student,
                StudentNotes => StudentNotes.owner,
                (student, note) => new
                {
                    studentName = student.name,
                    studentNote = note.Select(n => n.note)
                });

            foreach (var student in result)
            {
                Console.WriteLine(student.studentName);
                foreach(var note in student.studentNote)
                {
                    Console.Write(note + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
