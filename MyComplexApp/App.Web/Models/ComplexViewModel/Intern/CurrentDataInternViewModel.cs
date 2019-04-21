using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ComplexViewModel.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ComplexViewModel.Intern
{
    public class CurrentDataInternViewModel
    {
        public UserViewModel PersonalData { get; set; }
        public IList<ThemeViewModel> Themes { get; set; }
        public IList<ModuleViewModel> Modules { get; set; }
        public MarksViewModel Marks { get; set; }
        public IList<CommentViewModel> Comments { get; set; }
    }
}
