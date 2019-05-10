using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.ExamMark
{
    public class ExamMarkDto
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string ModuleName { get; set; }
        public double Mark { get; set; }
        public string Comment { get; set; }
    }
}
