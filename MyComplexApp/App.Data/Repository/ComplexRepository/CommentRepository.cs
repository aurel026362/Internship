using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.Abstractions;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Data.Repository.ComplexRepository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MyAppContext _context;

        public CommentRepository(MyAppContext ctxt)
        {
            _context = ctxt;
        }

        public IList<ComplexComment> GetComments()
        {
            var comments = _context.Comments.Select(x => new ComplexComment()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

            return comments;
        }

        public IList<ComplexComment> GetComments(long themeId)
        {
            var comments = _context.Comments.Where(x=>x.ThemeId.Equals(themeId)).Select(x => new ComplexComment()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

            return comments;
        }

        public IList<ComplexComment> GetComments(int page, long themeId)
        {
            var comments = _context.Comments.Where(x => x.ThemeId.Equals(themeId)).Select(x => new ComplexComment()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Content = x.Content,
                DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
            }).Skip(page * 10).Take(10).ToList();

            return comments;
        }

        public void AddComment(Comment com)
        {
            com.DateComment = DateTime.Now.Date;
            _context.Comments.Add(com);
            _context.SaveChanges();
        }

        public void AddComment(long userId, long themeId, string content)
        {
            var com = new Comment()
            {
                UserId = userId,
                ThemeId = themeId,
                Content = content,
                DateComment = DateTime.Now.Date
            };

            _context.Comments.Add(com);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
