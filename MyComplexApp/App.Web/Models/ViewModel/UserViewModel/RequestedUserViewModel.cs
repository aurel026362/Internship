using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.UserViewModel
{
    public class RequestedUserViewModel
    {
        public App.Web.Model.ViewModel.UserViewModel.UserViewModel User { get; set; }
        public string Role { get; set; }
    }
}
