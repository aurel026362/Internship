using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class ExamMarks
    {
        public long Id { get; set; }
        public long ExamenId { get; set; }
        public long InternId { get; set; }
        public double? Mark { get; set; }

        public virtual Exams Examen { get; set; }
        public virtual Interns Intern { get; set; }
    }
}
