using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.ThemeMarkViewModel
{
    public class AddThemeMarkViewModel
    {
        [Required]
        [Range(1,10, ErrorMessage ="Input value(min:1, max:10)!")]
        public double Mark { get; set; }

        public string Comment { get; set; }

        [Required]
        public long? InternId { get; set; }

        [Required]
        public long? ThemeId { get; set; }
    }
}
