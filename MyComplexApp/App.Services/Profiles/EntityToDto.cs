using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.Abstractions;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Dtos.DTOs.Exam;
using App.Services.Dtos.DTOs.ExamMark;
using App.Services.Dtos.DTOs.Group;
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
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<ComplexComment, CommentDto>();
            CreateMap<ComplexExam, ExamDto>();
            CreateMap<Module, ModuleDto>();
            CreateMap<ComplexTheme, ThemeDto>();

            CreateMap<ComplexEMark, ExamMarkDto>();
            CreateMap<ComplexTMark, ThemeMarkDto>();

            CreateMap<Group, GroupDto>();
            CreateMap<User, UserDto>();
        }
    }
}
