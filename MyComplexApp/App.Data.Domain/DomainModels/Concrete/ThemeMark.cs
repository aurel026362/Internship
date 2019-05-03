using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class ThemeMark : Entity
    {
        public int Mark { get; set; }
        public string Comment { get; set; }
        public long? InternId { get; set; }
        public long? ThemeId { get; set; }

        public Intern Intern { get; set; }
        public Theme theme { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
