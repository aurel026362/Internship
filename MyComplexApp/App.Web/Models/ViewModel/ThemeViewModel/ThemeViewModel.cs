using System;
using System.Collections.Generic;
using System.Text;

namespace App.Web.Model.ViewModel.ThemeViewModel
{
    public class ThemeViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? TimeOfTheme { get; set; }
        public string Source { get; set; }
        public string ModuleName { get; set; }
        public string MenthorEMail { get; set; }
    }
}
