using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForUser
{
    public class DataCurrentUser
    {
        public PersonalData PersonalData { get; set; }
        public Mark Marks { get; set; }
        public ICollection<Module> Modules { get; set; }
    }
}
