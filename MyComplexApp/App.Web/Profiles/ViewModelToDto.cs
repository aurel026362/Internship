using App.Services.Dtos.DTOs.Module;
using App.Services.Dtos.DTOs.Theme;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Models.ViewModel.ThemeViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Profiles
{
    public class ViewModelToDto : Profile
    {
        public ViewModelToDto()
        {
            CreateMap<AddThemeViewModel, ThemeDto>();
            CreateMap<ModuleViewModel, ModuleDto>();
        }
    }
}
