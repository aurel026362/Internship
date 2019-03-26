using System;
using System.Collections.Generic;
using TESTDB.Repository;

namespace TESTDB
{
    public partial class ExamMarks : Entity<long>
    {
        public long ExamenId { get; set; }
        public long InternId { get; set; }
        public double? Mark { get; set; }

        public virtual Exams Examen { get; set; }
        public virtual UsersIntern Intern { get; set; }
    }
}
