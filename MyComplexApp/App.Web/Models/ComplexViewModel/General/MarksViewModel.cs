using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ComplexViewModel.General
{
    public class MarksViewModel
    {
        public IList<ThemeMarkViewModel> ThemeMarks { get; set; }
        public IList<ExamMarkViewModel> ExamMarks { get; set; }
        public double AvgTMarks { get; set; }
        public double AvgEMarks { get; set; }
    }
}
