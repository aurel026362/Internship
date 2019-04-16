using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForUser
{
    public class InternExamMark
    {
        public string ModuleName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
