using App.Data.Interfaces.Abstractions;
using App.Services.Dtos.DTOs.Comment;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Profiles
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<CommentDto, ComplexComment>();
        }
    }
}
