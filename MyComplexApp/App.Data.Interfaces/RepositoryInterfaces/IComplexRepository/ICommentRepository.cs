using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface ICommentRepository
    {
        IList<Comment> GetComments();
        IList<Comment> GetComments(long themeId);
        IList<Comment> GetComments(int page, long themeId);
        void AddComment(Comment comment);
        void AddComment(long userId, long themeId, string content);
    }
}
