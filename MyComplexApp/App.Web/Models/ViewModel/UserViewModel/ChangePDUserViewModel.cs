using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.UserViewModel
{
    public class ChangePDUserViewModel
    {
        [Required]
        [StringLength(20, MinimumLength =2, ErrorMessage = "Please enter from 2 to 20 characters.")]
        public string FName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter from 2 to 20 characters.")]
        public string LName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
