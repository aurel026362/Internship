using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class UserMenthor : Entity
    {
        public long UserId {get;set;}

        public UserIntern Intern { get; set; }
        public User User { get; set; }
        public ICollection<Theme> Themes { get; set; }
    }
}
