using System;
using System.Collections.Generic;

namespace TESTDB
{
    public class UsersIntern
    {
        public UsersIntern()
        {
            ExamMarks = new HashSet<ExamMarks>();
            ThemeMarks = new HashSet<ThemeMarks>();
        }
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long UserId { get; set; }
        public long? MenthorId { get; set; }

        public virtual Group Group { get; set; }
        public virtual UsersMenthor Menthor { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ExamMarks> ExamMarks { get; set; }
        public virtual ICollection<ThemeMarks> ThemeMarks { get; set; }
    }
}
