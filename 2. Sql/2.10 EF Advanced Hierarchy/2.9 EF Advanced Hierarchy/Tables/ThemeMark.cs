using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class ThemeMark : Entity<long>
    {
        public int Mark { get; set; }
        public string Comment { get; set; }
        public long InternId { get; set; }
        public long ThemeId { get; set; }
        public UserIntern Intern { get; set; }
        public Theme theme { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
