using System;
using System.Collections.Generic;
using TESTDB.Repository;

namespace TESTDB
{
    public partial class ThemeMarks : Entity<long>
    {
        public long ThemeId { get; set; }
        public long InternId { get; set; }
        public double Mark { get; set; }
        public string Comment { get; set; }

        public virtual UsersIntern Intern { get; set; }
        public virtual Themes Theme { get; set; }
    }
}
