using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class UserIntern : Entity<long>
    {
        public long GroupId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }

        //public UserMenthor Menthor { get; set; }
        public Group Group { get; set; }
        public ICollection<ThemeMark> ThemeMarks { get; set; }
        public ICollection<ExamMark> ExamMarks { get; set; }
    }
}
