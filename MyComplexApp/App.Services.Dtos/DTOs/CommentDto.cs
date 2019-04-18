using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs
{
    public class CommentDto
    {
        public string EMail { get; set; }
        public string ThemeName { get; set; }
        public string DateComment { get; set; }
        public string Comment { get; set; }
    }
}
