using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.ThemeViewModel
{
    public class AddThemeViewModel
    {
        [Required]
        [StringLength(50, MinimumLength=1)]
        public string Name { get; set; }

        public string Source { get; set; }
        
        [Required]
        public long MenthorId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TimeOfTheme { get; set; }

        [Required]
        [Display(Name="Module")]
        public long ModuleId { get; set; }

    }
}
