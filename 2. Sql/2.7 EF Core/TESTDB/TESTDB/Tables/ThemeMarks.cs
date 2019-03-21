using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class ThemeMarks
    {
        public long Id { get; set; }
        public long ThemeId { get; set; }
        public long InternId { get; set; }
        public double Mark { get; set; }
        public string Comment { get; set; }

        public virtual Interns Intern { get; set; }
        public virtual Themes Theme { get; set; }
    }
}
