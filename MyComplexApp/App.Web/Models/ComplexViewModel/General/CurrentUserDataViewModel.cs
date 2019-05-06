using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Models.ViewModel.UserViewModel;
using System;
using System.Collections.Generic;

namespace App.Web.Models.ComplexViewModel.General
{
    public class CurrentUserDataViewModel
    {
        public UserDetailedViewModel PersonalData { get; set; }
        public ExamAndThemeViewModel ExamsAndThemes { get; set; }
        public IList<ThemeViewModel> Themes { get; set; }
        public IList<ModuleViewModel> Modules { get; set; }
        public MarksViewModel Marks { get; set; }
        public IList<CommentViewModel> Comments { get; set; }
    }
}
