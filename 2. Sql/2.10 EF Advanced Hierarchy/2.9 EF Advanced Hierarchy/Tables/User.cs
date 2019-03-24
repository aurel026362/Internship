using _2._9_EF_Advanced_Hierarchy.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class User : IEntity
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
