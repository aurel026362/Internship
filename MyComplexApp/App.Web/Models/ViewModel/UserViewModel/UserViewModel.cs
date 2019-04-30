using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Web.Model.ViewModel.UserViewModel
{
    public class UserViewModel
    {
        public long Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter from 2 to 20 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter from 2 to 20 characters.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
    }
}
