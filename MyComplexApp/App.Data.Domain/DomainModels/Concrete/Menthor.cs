using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Menthor : Entity
    {
        public long UserId {get;set;}

        public Intern Intern { get; set; }
        public User User { get; set; }
        public ICollection<Theme> Themes { get; set; }
    }
}
