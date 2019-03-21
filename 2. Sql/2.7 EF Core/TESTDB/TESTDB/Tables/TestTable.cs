using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Tables
{
    public partial class TestTable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long GroupsId { get; set; }
        public virtual Group Group { get; set; }
    }
}
