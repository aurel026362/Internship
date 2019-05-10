using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class ThemeMark : Entity
    {
        [Range(1, 10)]
        public double Mark { get; set; }
        public string Comment { get; set; }
        public long? InternId { get; set; }
        public long? ThemeId { get; set; }

        public Intern Intern { get; set; }
        public Theme Theme { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
