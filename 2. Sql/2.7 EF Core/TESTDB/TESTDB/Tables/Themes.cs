using System;
using System.Collections.Generic;
using TESTDB.Repository;

namespace TESTDB
{
    public partial class Themes : Entity<long>
    {
        public Themes()
        {
            ThemeMarks = new HashSet<ThemeMarks>();
        }
        public string Name { get; set; }
        public DateTime? TimeOfTheme { get; set; }
        public string Source { get; set; }
        public long? MenthorId { get; set; }
        public long ModuleId { get; set; }

        public virtual UsersMenthor Menthor { get; set; }
        public virtual Modules Module { get; set; }
        public virtual ICollection<ThemeMarks> ThemeMarks { get; set; }
    }
}
