using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class Theme : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? TimeOfTheme { get; set; }
        public string Source { get; set; }
        public long ModuleId { get; set; }
        public long MenthroId { get; set; }
        public Module Modulep { get; set; }
        public UserMenthor Menthor { get; set; }

        public ICollection<ThemeMark> ThemeMarks { get; set; }
    }
}
