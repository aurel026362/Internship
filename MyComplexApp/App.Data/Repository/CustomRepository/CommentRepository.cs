using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using Microsoft.EntityFrameworkCore;
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

        public IList<Comment> GetComments()
        {
            var comments = _context.Comments.Include(x=>x.Theme).Include(x=>x.User).OrderByDescending(x=>x.DateComment).ToList();

            return comments;
        }

        public IList<Comment> GetComments(long themeId)
        {
            var comments = _context.Comments.Include(x=>x.User).Include(x=>x.Theme)
                .Where(x=>x.ThemeId.Equals(themeId)).OrderByDescending(x => x.DateComment).Take(10).ToList();

            return comments;
        }

        public IList<Comment> GetComments(int page, long themeId)
        {
            var comments = _context.Comments.Include(x=>x.Theme).Include(x=>x.User)
                .Where(x => x.ThemeId.Equals(themeId)).OrderByDescending(x => x.DateComment).Skip(page * 10).Take(10).ToList();

            return comments;
        }

        public void AddComment(Comment com)
        {
            com.DateComment = DateTime.Now.Date;
            _context.Comments.Add(com);
        }

        public void AddComment(long userId, long themeId, string content)
        {
            var com = new Comment()
            {
                UserId = userId,
                ThemeId = themeId,
                Content = content,
                DateComment = DateTime.Now
            };

            _context.Comments.Add(com);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
