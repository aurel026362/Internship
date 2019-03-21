using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Group
    {
        public Group()
        {
            Interns = new HashSet<Interns>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual ICollection<Interns> Interns { get; set; }
    }
}
