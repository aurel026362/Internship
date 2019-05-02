using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ComplexViewModel.Intern;
using App.Web.Models.ViewModel.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ComplexViewModel.Admin
{
    public class AdminDataViewModel
    {
        public CurrentUserDataViewModel Data { get; set; }
        public IList<UserDetailedViewModel> Users { get; set; }
    }
}
