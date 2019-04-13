using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Comment : Entity
    {
        public long? UserId { get; set; }
        public long? ThemeId { get; set; }
        public DateTime DateComment { get; set; }
        public User User { get; set; }
        public Theme Theme { get; set; }
    }
}
