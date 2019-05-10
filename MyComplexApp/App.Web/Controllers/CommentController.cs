using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ViewModel.UserViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IUserService _userService;

        private SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IUserService userService, SignInManager<User> signInManager, IMapper mapper)
        {
            _commentService = commentService;
            _userService = userService;

            _signInManager = signInManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetComments(long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUser = _userService.GetUserById(currentId);

            var data = new UserProfileViewModel();

            var personaldata = _userService.GetUserById(currentId);
            data.PersonalData = _mapper.Map<UserDetailedViewModel>(personaldata);

            var comments = _commentService.GetComments(themeId);
            data.Comments = _mapper.Map<IList<CommentViewModel>>(comments);
            
            return Json(data);
        }

        [HttpGet]
        public ActionResult GetMoreComments(long themeId, int pageNr)
        {
            var commentsDto = _commentService.GetComments(pageNr, themeId);
            var comments = _mapper.Map<IList<CommentViewModel>>(commentsDto);
            return Json(comments);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitComment(string comment, long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            _commentService.AddComment(currentId, themeId, comment);
            return StatusCode(200);
        }
    }
}