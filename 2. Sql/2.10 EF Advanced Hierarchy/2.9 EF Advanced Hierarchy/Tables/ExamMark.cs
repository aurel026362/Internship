using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class ExamMark : IEntity
    {
        public long Id { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
        public long InternId { get; set; }
        public long ExamId { get; set; }

        public UserIntern Intern { get; set; }
        public Exam Exam { get; set; }
    }
}
