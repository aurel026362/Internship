using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.Module;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Dtos.DTOs.Group;
using App.Services.Dtos.DTOs.User;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.GroupViewModel;
using App.Web.Model.ViewModel.UserViewModel;

namespace App.Web.Profiles
{
    public class DtoToViewModel : Profile
    {
        public DtoToViewModel()
        {
            CreateMap<CommentDto, CommentViewModel>();
            CreateMap<ExamDto, ExamViewModel>();
            CreateMap<ModuleDto, ModuleViewModel>();
            CreateMap<ThemeDto, ThemeViewModel>();

            CreateMap<ExamMarkDto, ExamMarkViewModel>();
            CreateMap<ThemeMarkDto, ThemeMarkViewModel>();

            CreateMap<GroupDto, GroupViewModel>();
            CreateMap<UserDto, UserViewModel>();
        }
    }
}
