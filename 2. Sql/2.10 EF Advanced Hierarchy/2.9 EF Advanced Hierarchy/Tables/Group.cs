using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class Group : Entity<long>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<UserIntern> Interns { get; set; }
    }
}
