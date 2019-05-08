using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.ThemeMark
{
    public class AddThemeMarkDto
    {
        public int Mark { get; set; }

        public string Comment { get; set; }
        public long? InternId { get; set; }
        public long? ThemeId { get; set; }
    }
}
