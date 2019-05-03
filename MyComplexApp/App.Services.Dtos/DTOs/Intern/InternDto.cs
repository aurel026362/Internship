using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.Intern
{
    public class InternDto
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long UserId { get; set; }
        public long? MenthorId { get; set; }
    }
}
