using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Services.Dtos.DTOs.Comment;
using App.Services.Interfaces.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public void AddComment(CommentDto comment)
        {
            //var com = _mapper.Map<ComplexComment>(comment);
            //_commentRepository.AddComment(com);
        }

        public void AddComment(long userId, long themeId, string content)
        {
            _commentRepository.AddComment(userId, themeId, content);
        }

        public IList<CommentDto> GetComments()
        {
            var list = _commentRepository.GetComments().Select(x => new CommentDto()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/mm/yyyy hh:mm:ss")
            }).ToList();
            
            return list;
        }

        public IList<CommentDto> GetComments(long themeId)
        {
            var list = _commentRepository.GetComments(themeId).Select(x => new CommentDto()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/mm/yyyy hh:mm:ss")
            }).ToList();
            
            return list;
        }

        public IList<CommentDto> GetComments(int page, long themeId)
        {
            var list = _commentRepository.GetComments(page, themeId).Select(x => new CommentDto()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/mm/yyyy hh:mm:ss")
            }).ToList();

            return list;
        }
    }
}
