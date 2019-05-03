using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Module : Entity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Theme> Themes { get; set; }
        public Exam Exam { get; set; }
    }
}
