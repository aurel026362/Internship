using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Exams
    {
        public Exams()
        {
            ExamMarks = new HashSet<ExamMarks>();
        }

        public long Id { get; set; }
        public DateTime? DateOfExamen { get; set; }
        public long ModuleId { get; set; }

        public virtual Modules Module { get; set; }
        public virtual ICollection<ExamMarks> ExamMarks { get; set; }
    }
}
