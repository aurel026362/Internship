using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class Exam : Entity<long>
    {
        public DateTime Date { get; set; }
        public long ModuleId { get; set; }

        public Module Module { get; set; }
        public ICollection<ExamMark> ExamMarks { get; set; }
    }
}
