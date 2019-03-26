using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Tables
{
    public class Module : Entity<long>
    {
        public string Name { get; set; }
        public DateTime DateStart { get; set; }

        public ICollection<Theme> Themes { get; set; }
        public Exam Exam { get; set; }
    }
}
