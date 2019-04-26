using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Web.Model.ViewModel.ModuleViewModel
{
    public class ModuleViewModel
    {
        public long Id { get; set; }

        [Required]
        [Remote(action: "CheckModule", controller: "Intern", ErrorMessage ="This Theme exist!")]
        public string Name { get; set; }

        [Display(Name="Date Start")]
        public DateTime DateStart { get; set; }
    }
}
