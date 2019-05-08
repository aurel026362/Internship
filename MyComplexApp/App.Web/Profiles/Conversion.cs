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
using App.Web.Models.ViewModel.UserViewModel;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;
using App.Web.Models.ViewModel.MenthorViewModel;
using App.Web.Models.ViewModel.InternViewModel;
using App.Web.Models.ViewModel.ThemeMarkViewModel;

namespace App.Web.Profiles
{
    public class Conversion : Profile
    {
        public Conversion()
        {
            CreateMap<CommentDto, CommentViewModel>().ReverseMap();
            CreateMap<ExamDto, ExamViewModel>().ReverseMap();
            CreateMap<ModuleDto, ModuleViewModel>().ReverseMap();
            CreateMap<ThemeDto, ThemeViewModel>().ReverseMap();

            CreateMap<ExamMarkDto, ExamMarkViewModel>().ReverseMap(); 
            CreateMap<ThemeMarkDto, ThemeMarkViewModel>().ReverseMap();
            CreateMap<AddThemeMarkDto, AddThemeMarkViewModel>().ReverseMap();

            CreateMap<UserDetailedDto, UserDetailedViewModel>().ReverseMap();
            CreateMap<GroupDto, GroupViewModel>().ReverseMap();
            CreateMap<UserDto, UserViewModel>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDetailedViewModel>().ReverseMap();

            CreateMap<InternDto, InternViewModel>().ReverseMap();
            CreateMap<MenthorDto, MenthorViewModel>().ReverseMap();
        }
    }
}
