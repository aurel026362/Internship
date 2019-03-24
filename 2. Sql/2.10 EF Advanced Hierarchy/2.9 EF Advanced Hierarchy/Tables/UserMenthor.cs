using _2._9_EF_Advanced_Hierarchy.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class UserMenthor : User
    {
        public string Job { get; set; }
        public string Level { get; set; }
        public int? Experience { get; set; }

        public ICollection<Theme> Themes { get; set; }
    }
}
