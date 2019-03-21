using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Menthors
    {
        public Menthors()
        {
            Themes = new HashSet<Themes>();
        }

        public long Id { get; set; }
        public long UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual Interns Interns { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
    }
}
