using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.Theme
{
    public class ThemeDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public string Source { get; set; }
        public string ModuleName { get; set; }
        public string MenthorEMail { get; set; }
    }
}
