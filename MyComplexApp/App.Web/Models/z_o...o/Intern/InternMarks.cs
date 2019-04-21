using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForIntern
{
    public class InternMarks
    {
        public long Id { get; set; }
        public string TName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
    }
}
