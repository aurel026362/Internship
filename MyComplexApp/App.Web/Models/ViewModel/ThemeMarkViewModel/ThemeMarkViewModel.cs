using System;
using System.Collections.Generic;
using System.Text;

namespace App.Web.Model.ViewModel.ThemeMarkViewModel
{
    public class ThemeMarkViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string ThemeName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
    }
}
