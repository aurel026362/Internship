using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Services.Interfaces;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ViewModel.ThemeViewModel;
using App.Web.Models.ViewModel.UserViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace App.Web.Controllers
{
    [Authorize]
    public class InternController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;
        private readonly ICommentService _commentService;
        private readonly IEMarkService _examMarkService;
        private readonly IExamService _examService;
        private readonly IGroupService _groupService;
        private readonly IModuleService _moduleService;
        private readonly IThemeService _themeService;
        private readonly ITMarkService _themeMarkService;
        private readonly IMapper _mapper;

        public InternController(SignInManager<User> signInManager, IMapper mapper,
            IUserService userService,
            ICommentService commentService,
            IEMarkService examMarkService,
            IExamService examService,
            IGroupService groupService,
            IModuleService moduleService,
            IThemeService themeService,
            ITMarkService themeMarkService
            )
        {
            _userService = userService;
            _commentService = commentService;
            _examMarkService = examMarkService;
            _examService = examService;
            _groupService = groupService;
            _moduleService = moduleService;
            _themeService = themeService;
            _themeMarkService = themeMarkService;

            _signInManager = signInManager;
            _mapper = mapper;
        }

        [Authorize(Roles = "Intern")]
        public IActionResult Index()
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new CurrentUserDataViewModel();
            var user = _userService.GetUserById(currentId);
            person.PersonalData = _mapper.Map<UserDetailedViewModel>(user);
            var currentTMarks = _themeMarkService.GetThemeMarksByUserId(currentId);

            var marks = new MarksViewModel();
            marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(currentTMarks);
            var currentEMarks = _examMarkService.GetExamMarksByUserId(currentId);
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(currentEMarks);
            person.Marks = marks;
            var modules = _moduleService.GetModules();
            person.Modules = _mapper.Map<IList<ModuleViewModel>>(modules);

            var themes = _themeService.GetThemes();
            person.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _commentService.GetComments();
            person.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return View(person);
        }

        [HttpGet]
        public async Task<IActionResult> GetMarks(long moduleId, long userId)
        {
            //var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            IList<ThemeMarkViewModel> tmarks;

            if (!moduleId.Equals(0))
            {
                var list = _themeMarkService.GetThemeMarks(userId, moduleId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }
            else
            {
                var list = _themeMarkService.GetThemeMarksByUserId(userId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }

            var examMarksDto = _examMarkService.GetExamMarksByUserId(userId);

            var marks = new MarksViewModel();
            marks.ThemeMarks = tmarks;
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(examMarksDto);
            return Json(marks);
            //return PartialView("_GetMarks", tmarks);
        }

        [HttpGet]
        public async Task<IActionResult> GetComments(long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUser = _userService.GetUserById(currentId);

            var data = new CurrentUserDataViewModel();

            var personaldata = _userService.GetUserById(currentId);
            data.PersonalData = _mapper.Map<UserDetailedViewModel>(personaldata);

            var comments = _commentService.GetComments(themeId);
            data.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            //return PartialView("../GeneralViews/_GetComments", data);
            return Json(data);
        }

        [HttpGet]
        public ActionResult GetMoreComments(long themeId, int pageNr)
        {
            var commentsDto = _commentService.GetComments(pageNr, themeId);
            var comments = _mapper.Map<IList<CommentViewModel>>(commentsDto);
            //var result = JsonConvert.SerializeObject(comments);
            //return Content(result, "application/json");
            return Json(comments);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitComment(string comment, long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            _commentService.AddComment(currentId, themeId, comment);
            return StatusCode(200);
        }

        //[HttpPost]
        //public async Task<IActionResult> EditData(string fname, string lname, string phone, DateTime dbirth)
        //{
        //    //if (!ModelState.IsValid) { }
        //    long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
        //    _userService.UpdateUser(currentId, fname, lname, phone, dbirth);
        //    //var user = await _context.Users.FindAsync(currentId);
        //    //user.FirstName = fname;
        //    //user.LastName = lname;
        //    //user.PhoneNumber = phone;
        //    //user.DateOfBirth = dbirth;
        //    //_context.Update(user);
        //    //_context.SaveChanges();
        //    return StatusCode(200);
        //}

        [HttpPost]
        public async Task<IActionResult> EditData(UserViewModel model)
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var user = _userService.GetUserById(currentId);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.DateOfBirth = model.DateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            //_userService.Save();
            return StatusCode(200);
        }
    }
}