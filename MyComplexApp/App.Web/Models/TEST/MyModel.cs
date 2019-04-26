using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.TEST
{
    public class MyModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        //[Remote(action: "Method", controller: "Intern", ErrorMessage = "sadasd")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "asdsad sadsa")]
        public string ConfirmPassword { get; set; }
        
        [Required]
        public string Gender { get; set; }

        
        public IList<LanguageOption> Languages { get; set; }

        [Required]
        public string Country { get; set; }
        public int? ExperienceYear { get; set; }
    }

    public class LanguageOption
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }
}
