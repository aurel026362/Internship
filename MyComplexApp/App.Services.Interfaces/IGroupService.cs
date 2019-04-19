using App.Services.Dtos.DTOs.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface IGroupService
    {
        IList<GroupDto> GetGroups();
    }
}
