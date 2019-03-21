﻿using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Themes
    {
        public Themes()
        {
            ThemeMarks = new HashSet<ThemeMarks>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? TimeOfTheme { get; set; }
        public string Source { get; set; }
        public long? MenthorId { get; set; }
        public long ModuleId { get; set; }

        public virtual Menthors Menthor { get; set; }
        public virtual Modules Module { get; set; }
        public virtual ICollection<ThemeMarks> ThemeMarks { get; set; }
    }
}
