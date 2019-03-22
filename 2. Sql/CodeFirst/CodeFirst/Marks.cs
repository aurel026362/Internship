using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class Marks
    {
        public long Id { get; set; }
        public string Discipline { get; set; }
        public long StudentId { get; set; }

        public Student student { get; set; }
    }
}
