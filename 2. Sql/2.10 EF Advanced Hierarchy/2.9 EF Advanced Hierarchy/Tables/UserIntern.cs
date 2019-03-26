using _2._9_EF_Advanced_Hierarchy.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class UserIntern : User
    {
        public long GroupId { get; set; }

        //public UserMenthor Menthor { get; set; }
        public Group Group { get; set; }
        public ICollection<ThemeMark> ThemeMarks { get; set; }
        public ICollection<ExamMark> ExamMarks { get; set; }
    }
}
