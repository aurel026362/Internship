using App.Data.Domain.DomainModels.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Data.Domain.DomainModels.Identity
{
    public class User : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        //public string NumberPhone { get; set; }
        //public string Login { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }

        public UserIntern Intern { get; set; }
        public UserMenthor Menthor { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
