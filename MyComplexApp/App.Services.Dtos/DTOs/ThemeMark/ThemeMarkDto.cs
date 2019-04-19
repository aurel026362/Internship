using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.ThemeMark
{
    public class ThemeMarkDto
    {
        public string UserEmail { get; set; }
        public string ThemeName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
    }
}
