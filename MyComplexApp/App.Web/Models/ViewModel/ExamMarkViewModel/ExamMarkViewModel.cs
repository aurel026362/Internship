﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Web.Model.ViewModel.ExamMarkViewModel
{
    public class ExamMarkViewModel
    {
        public string UserEmail { get; set; }
        public string ModuleName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
    }
}