using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Modules
    {
        public Modules()
        {
            Themes = new HashSet<Themes>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual Exams Exams { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
    }
}
