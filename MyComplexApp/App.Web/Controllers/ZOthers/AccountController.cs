using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Interfaces;
using App.Services.Interfaces.ContentInternshipService;
using App.Services.Interfaces.UserService;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ComplexViewModel.Intern;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IInternAchievements _internAchievements;
        private readonly IUserService _userService;
        private readonly IContentInternshipService _contentInternshipService;
        private readonly IMapper _mapper;

        public AccountController(SignInManager<User> signInManager, IMapper mapper,
            IInternAchievements internAchievements, IUserService userService, IContentInternshipService contentInternshipService)
        {
            _signInManager = signInManager;
            _internAchievements = internAchievements;
            _userService = userService;
            _contentInternshipService = contentInternshipService;
            _mapper = mapper;
        }

        [Authorize(Roles ="Intern, Menthor")]
        public IActionResult Index()
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new CurrentUserDataViewModel();
            var user = _userService.GetUserById(currentId);
            person.PersonalData = _mapper.Map<UserViewModel>(user);
            var currentTMarks = _internAchievements.GetThemeMarks();

            var marks = new MarksViewModel();
            marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(currentTMarks);
            var currentEMarks = _internAchievements.GetExamMarks();
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(currentEMarks);
            person.Marks = marks;
            var modules = _contentInternshipService.GetModules();
            person.Modules = _mapper.Map<IList<ModuleViewModel>>(modules);

            var themes = _contentInternshipService.GetThemes();
            person.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _contentInternshipService.GetComments();
            person.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return View(person);
        }

        [HttpGet]
        [Authorize(Roles = "Intern")]
        public async Task<IActionResult> GetMarks(long moduleId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            IList<ThemeMarkViewModel> tmarks;

            if (moduleId.Equals(0))
            {
                var list = _internAchievements.GetThemeMarksByUserId(currentId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }
            else
            {
                var list = _internAchievements.GetThemeMarks(currentId, moduleId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }

            return PartialView("Intern/_GetMarks", tmarks);
        }

        [HttpGet]
        [Authorize(Roles = "Intern, Menthor, Admin")]
        public async Task<IActionResult> GetComments(long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUser = _userService.GetUserById(currentId);
            //_context.Users.FirstOrDefault(x => x.Id.Equals(currentId));

            var data = new CurrentUserDataViewModel();

            var personaldata = _userService.GetUserById(currentId);
            data.PersonalData = _mapper.Map<UserViewModel>(personaldata);

            var comments = _contentInternshipService.GetComments(themeId);
            data.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return PartialView("../GeneralViews/_GetComments", data);
        }

        [HttpGet]
        [Authorize(Roles = "Intern, Menthor, Admin")]
        public ActionResult GetMoreComments(long themeId, int pageNr)
        {
            var commentsDto = _contentInternshipService.GetComments(pageNr, themeId);
            var comments = _mapper.Map<IList<CommentViewModel>>(commentsDto);
            var result = JsonConvert.SerializeObject(comments);
            return Content(result, "application/json");
        }

        [HttpPost]
        [Authorize(Roles = "Intern, Menthor, Admin")]
        public async Task<IActionResult> SubmitComment(string comment, long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            _contentInternshipService.AddComment(currentId, themeId, comment);
            return StatusCode(200);
        }

        [HttpPost]
        [Authorize(Roles = "Intern, Menthor, Admin")]
        public async Task<IActionResult> EditData(UserViewModel model)
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var user = _userService.GetUserById(currentId);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.DateOfBirth = model.DateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            _userService.Save();
            return StatusCode(200);
        }
    }
}