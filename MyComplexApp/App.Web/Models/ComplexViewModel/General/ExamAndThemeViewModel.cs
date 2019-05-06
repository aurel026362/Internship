using App.Web.Model.ViewModel.ExamViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ComplexViewModel.General
{
    public class ExamAndThemeViewModel
    {
        public IList<ThemeViewModel> Themes { get; set; }
        public IList<ExamViewModel> Exams { get; set; }
    }
}
