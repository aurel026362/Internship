using App.Data.Domain.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface IUser
    {
        List<User> GetAllUsers(); 
    }
}
