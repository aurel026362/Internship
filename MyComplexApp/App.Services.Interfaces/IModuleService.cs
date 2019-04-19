using App.Services.Dtos.DTOs.Module;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface IModuleService
    {
        IList<ModuleDto> GetModules();
    }
}
