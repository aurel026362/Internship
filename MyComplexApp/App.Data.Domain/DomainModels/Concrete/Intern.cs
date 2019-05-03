using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Intern : Entity
    {
        public long? GroupId { get; set; }
        public long UserId { get; set; }
        public long? MenthorId { get; set; }
        public User User { get; set; }
        public Menthor Menthor { get; set; }
        public Group Group { get; set; }
        public ICollection<ThemeMark> ThemeMarks { get; set; }
        public ICollection<ExamMark> ExamMarks { get; set; }
    }
}
