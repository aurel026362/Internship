using App.Web.Models.ComplexViewModel.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.UserViewModel
{
    public class UserDetailedViewModel
    {
        public long Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength =2)]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        [StringLength(20, MinimumLength = 7)]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(20, MinimumLength = 2)]
        public string EMail { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
        public int AccessFailedCount { get; set; }
        
    }
}
