using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Exam : Entity
    {
        public DateTime Date { get; set; }
        public long ModuleId { get; set; }

        public Module Module { get; set; }
        public ICollection<ExamMark> ExamMarks { get; set; }
    }
}
