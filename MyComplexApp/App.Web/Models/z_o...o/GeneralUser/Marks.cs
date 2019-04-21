using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ForUser
{
    public class Marks
    {
        public IList<InternTMark> ThemeMarks { get; set; }
        public IList<InternExamMark> ExamMarks { get; set; }
    }
}
