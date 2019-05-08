using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Dtos.DTOs.Group;
using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;
using App.Services.Dtos.DTOs.Module;
using App.Services.Dtos.DTOs.Theme;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Dtos.DTOs.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Profiles
{
    public class Conversion : Profile
    {
        public Conversion()
        {
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Exam, ExamDto>().ReverseMap();
            CreateMap<Module, ModuleDto>().ReverseMap();
            CreateMap<Theme, ThemeDto>().ReverseMap();

            CreateMap<ExamMark, ExamMarkDto>().ReverseMap();
            CreateMap<ThemeMark, ThemeMarkDto>().ReverseMap();
            CreateMap<ThemeMark, AddThemeMarkDto>().ReverseMap();

            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDetailedDto>().ReverseMap();

            CreateMap<Intern, InternDto>().ReverseMap();
            CreateMap<Menthor, MenthorDto>().ReverseMap();
        }
    }
}
