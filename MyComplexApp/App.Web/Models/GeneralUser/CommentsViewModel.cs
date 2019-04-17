using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.GeneralUser
{
    public class CommentsViewModel
    {
        public string EMail { get; set; }
        public string ThemeName { get; set; }
        public string DateComment { get; set; }
        public string Comment { get; set; }
    }
}
