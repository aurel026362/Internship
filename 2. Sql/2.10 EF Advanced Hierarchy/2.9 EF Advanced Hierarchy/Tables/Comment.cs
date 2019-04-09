using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class Comment : Entity<long>
    {
        public long UserId { get; set; }
        public long ThemeId { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Theme Theme { get; set; }
    }
}
