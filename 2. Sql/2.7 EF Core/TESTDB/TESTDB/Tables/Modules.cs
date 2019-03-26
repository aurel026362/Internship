using System;
using System.Collections.Generic;
using TESTDB.Repository;
using TESTDB.Tables;

namespace TESTDB
{
    public partial class Modules : Entity<long>
    {
        public Modules()
        {
            Themes = new HashSet<Themes>();
        }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual Exams Exams { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
    }
}
