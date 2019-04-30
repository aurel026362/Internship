using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.ViewModel.CommentViewModel
{
    public class AddCommentViewModel
    {
        public long UserId { get; set; }
        public long ThemeId { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime DateComment { get; set; }
    }
}
