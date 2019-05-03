using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.CommentViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public void AddComment(long userId, long themeId, string content)
        //{
        //    _commentService.AddComment(userId, themeId, content);
        //}

        //public async Task<IActionResult> GetComments()
        //{
        //    var list = _commentService.GetComments();
        //    var listDto = _mapper.Map<IList<CommentViewModel>>(list);

        //    //return listDto;
        //    return null;
        //}

        //public async Task<IActionResult> GetComments(long themeId)
        //{
        //    var list = _commentService.GetComments(themeId);
        //    var listDto = _mapper.Map<IList<CommentViewModel>>(list);

        //    return null;
        //}

        //public async Task<IActionResult> GetComments(int page, long themeId)
        //{
        //    var list = _commentService.GetComments(page, themeId);
        //    var listDto = _mapper.Map<IList<CommentViewModel>>(list);

        //    return null;
        //}
    }
}