using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Services.Dtos.DTOs.Comment
{
    public class AddCommentDto
    {
        public long UserId { get; set; }
        public long ThemeId { get; set; }
        public string Content { get; set; }
        public DateTime DateComment { get; set; }
    }
}
