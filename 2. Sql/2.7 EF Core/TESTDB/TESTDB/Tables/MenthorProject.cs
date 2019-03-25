using System;
using System.Collections.Generic;
using System.Text;
using TESTDB.Repository;

namespace TESTDB.Tables
{
    public class MenthorProject
    {
        public long MenthorId { get; set; }
        public long ProjectId { get; set; }
        public UsersMenthor Menthor { get; set; }
        public Project Project { get; set; }
    }
}
