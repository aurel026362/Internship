using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class Student
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TeacherId { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Marks> SMarks { get; set; }
    }
}
