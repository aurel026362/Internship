using App.Data.Domain.DomainModels.Identity;
using App.Web.Models.ForUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.Admin
{
    public class AdminData
    {
        public PersonalData PersonalData { get; set; }
        public IList<User> Users { get; set; }
    }
}
