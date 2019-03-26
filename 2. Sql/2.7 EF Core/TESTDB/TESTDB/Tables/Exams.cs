using System;
using System.Collections.Generic;
using TESTDB.Repository;

namespace TESTDB
{
    public partial class Exams : Entity<long>
    {
        public Exams()
        {
            ExamMarks = new HashSet<ExamMarks>();
        }
        public DateTime? DateOfExamen { get; set; }
        public long ModuleId { get; set; }

        public virtual Modules Module { get; set; }
        public virtual ICollection<ExamMarks> ExamMarks { get; set; }
    }
}
