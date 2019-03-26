using _2._9_EF_Advanced_Hierarchy.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class UserMenthor : User
    {
        //public virtual UserIntern Intern { get; set; }
        public ICollection<Theme> Themes { get; set; }
    }
}
