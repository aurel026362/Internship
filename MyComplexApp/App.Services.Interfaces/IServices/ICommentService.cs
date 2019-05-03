using App.Services.Dtos.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface ICommentService
    {
        IList<CommentDto> GetComments();
        IList<CommentDto> GetComments(long themeId);
        IList<CommentDto> GetComments(int page, long themeId);
        void AddComment(CommentDto comment);
        void AddComment(long userId, long themeId, string content);
    }
}
