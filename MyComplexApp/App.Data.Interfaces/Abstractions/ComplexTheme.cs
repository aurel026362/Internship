using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.Abstractions
{
    public class ComplexTheme
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateStart { get; set; }
        public string Source { get; set; }
        public string ModuleName { get; set; }
        public string MenthorEMail { get; set; }
    }
}
