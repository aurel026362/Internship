using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.GeneralUser
{
    public class CurrentUserCommsViewModel
    {
        public string CurrentUserEmail { get; set; }
        public IList<CommentsViewModel> Comments { get; set; }
    }
}
