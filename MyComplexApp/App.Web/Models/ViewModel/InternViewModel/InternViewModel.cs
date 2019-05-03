using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.InternViewModel
{
    public class InternViewModel
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long UserId { get; set; }
        public long? MenthorId { get; set; }
    }
}
