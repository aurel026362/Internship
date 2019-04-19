using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface ICommentRepository
    {
        IList<ComplexComment> GetComments();
        IList<ComplexComment> GetComments(long themeId);
        IList<ComplexComment> GetComments(int page, long themeId);
        void AddComment(Comment comment);
        void AddComment(long userId, long themeId, string content);
    }
}
