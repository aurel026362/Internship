using System;
using System.Collections.Generic;
using System.Text;
using TESTDB.Repository;

namespace TESTDB.Tables
{
    public class Project : Entity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int DurationDays { get; set; }
        public ICollection<MenthorProject> MenthorProjects { get; set; }
    }
}
