using System;
using System.Collections.Generic;
using TESTDB.Repository;
using TESTDB.Tables;

namespace TESTDB
{
    public partial class UsersMenthor : Users
    {
        public UsersMenthor()
        {
            Themes = new HashSet<Themes>();
        }
        public long UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual UsersIntern Interns { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
        public ICollection<MenthorProject> MenthorProjects { get; set; }
    }
}
