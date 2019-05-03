using App.Services.Dtos.DTOs.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface IGroupService
    {
        IList<GroupDto> GetGroups();
        GroupDto GetGroupById(long id);
    }
}
