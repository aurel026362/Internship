using App.Web.Models.ForUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForMenthor
{
    public class MenthorData
    {
        public PersonalData PersonalData { get; set; }
        public IList<InternAllMarks> InternMarks { get; set; }
    }
}
