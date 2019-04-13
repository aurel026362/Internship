using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Theme : Entity
    {
        public string Name { get; set; }
        public DateTime? TimeOfTheme { get; set; }
        public string Source { get; set; }
        public long ModuleId { get; set; }
        public long MenthorId { get; set; }

        public Module Modulep { get; set; }
        public UserMenthor Menthor { get; set; }
        public ICollection<ThemeMark> ThemeMarks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
