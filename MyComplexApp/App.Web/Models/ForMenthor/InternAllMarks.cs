using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForMenthor
{
    public class InternAllMarks
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Theme { get; set; }
        public string EMail { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }

    }
}
