using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Dtos.DTOs.User
{
    public class RequestedUserDto
    {
        public UserDto User { get; set; }
        public string Role { get; set; }
    }
}
