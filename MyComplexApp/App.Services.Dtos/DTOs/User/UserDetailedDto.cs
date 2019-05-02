using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.User
{
    public class UserDetailedDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
        public int AccessFailedCount { get; set; }
    }
}
