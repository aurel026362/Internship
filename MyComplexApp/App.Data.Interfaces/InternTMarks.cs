using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces
{
    public class InternTMarks
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public long GroupId { get; set; }
        public ICollection<ThemeMark> ThemeMarks { get; set; }
    }
}
