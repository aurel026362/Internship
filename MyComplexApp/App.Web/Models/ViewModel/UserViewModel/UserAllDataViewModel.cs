using App.Web.Models.ComplexViewModel.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.UserViewModel
{
    public class UserAllDataViewModel
    {
        public UserDetailedViewModel Details { get; set; }
        public MarksViewModel Marks { get; set; }
    }
}
