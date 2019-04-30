using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.UserViewModel
{
    public class ChangePassUserViewModel
    {
        [Required]
        [Remote(action:"", controller:"", ErrorMessage = "You have entered the incorrect password!")]
        public string CurrentPassword { get; set; }

        [Required]
        [StringLength(6)]
        public string NewPassword { get; set; }

        [Required]
        [StringLength(6)]
        [Compare("NewPassword", ErrorMessage = "The password does not coincide!")]
        public string ConfirmPassword { get; set; }
    }
}
