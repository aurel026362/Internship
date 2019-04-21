using App.Data.Domain.DomainModels.Concrete;
using App.Web.Models.GeneralUser;
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
        public Marks Marks { get; set; }
        public IList<Theme> Themes { get; set; }
        public IList<Module> Modules { get; set; }
        public CurrentUserCommsViewModel CurrentUserComms { get; set; }
    }
}
