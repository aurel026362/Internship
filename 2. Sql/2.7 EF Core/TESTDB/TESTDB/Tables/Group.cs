using System;
using System.Collections.Generic;
using TESTDB.Repository;

namespace TESTDB
{
    public partial class Group : Entity<long>
    {
        public Group()
        {
            Interns = new HashSet<UsersIntern>();
        }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual ICollection<UsersIntern> Interns { get; set; }
    }
}
