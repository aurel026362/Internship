using App.Data.Domain.DomainModels.Concrete;
using App.Web.Models.ViewModel.ThemeViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<AddThemeViewModel, Theme>();
        }
    }
}
