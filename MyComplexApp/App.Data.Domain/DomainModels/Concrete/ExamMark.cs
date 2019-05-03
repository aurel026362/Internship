using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class ExamMark : Entity
    {
        public int Mark { get; set; }
        public string Comment { get; set; }
        public long InternId { get; set; }
        public long ExamId { get; set; }
        public Intern Intern { get; set; }
        public Exam Exam { get; set; }
    }
}
