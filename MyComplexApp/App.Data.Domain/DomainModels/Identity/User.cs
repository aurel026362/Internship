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

        //public Intern Intern { get; set; }
        //public Menthor Menthor { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<IdentityUserRole<long>> Roles { get; set; }
    }
}
