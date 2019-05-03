using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public class Group : Entity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Intern> Interns { get; set; }
    }
}
