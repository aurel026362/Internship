using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Web.Models;
using Microsoft.AspNetCore.Identity;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Context;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using App.Services.Interfaces.IServices;
using AutoMapper;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ViewModel.UserViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Models.ComplexViewModel.Admin;

namespace App.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;
        private readonly ICommentService _commentService;
        private readonly IExamMarkService _examMarkService;
        private readonly IExamService _examService;
        private readonly IGroupService _groupService;
        private readonly IModuleService _moduleService;
        private readonly IThemeService _themeService;
        private readonly IThemeMarkService _themeMarkService;
        private readonly IMapper _mapper;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper,
            IUserService userService,
            ICommentService commentService,
            IExamMarkService emarkService,
            IExamService examService,
            IGroupService groupService,
            IModuleService moduleService,
            IThemeService themeService,
            IThemeMarkService themeMarkService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _commentService = commentService;
            _examMarkService = emarkService;
            _examService = examService;
            _groupService = groupService;
            _moduleService = moduleService;
            _themeService = themeService;
            _themeMarkService = themeMarkService;
            _mapper = mapper;
        }

        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Contacts() => View();

        public IActionResult Privacy() => View();

        public IActionResult Success() => View();


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Authorize(Roles = "Intern, Menthor, Admin")]
        public IActionResult DashBoard()
        {
            var userListProfile = new UserProfileListViewModel();
            var person = new UserProfileViewModel();
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUserDto = _userService.GetUserById(currentId);
            person.PersonalData = _mapper.Map<UserDetailedViewModel>(currentUserDto);

            var modulesDto = _moduleService.GetModules();
            var modules = _mapper.Map<IList<ModuleViewModel>>(modulesDto);
            var themesDto = _themeService.GetThemes();
            var themes = _mapper.Map<IList<ThemeViewModel>>(themesDto);
            var commentsDto = _commentService.GetComments();
            var comments = _mapper.Map<IList<CommentViewModel>>(commentsDto);

            person.Modules = modules;
            person.Themes = themes;
            person.Comments = comments;

            var marks = new MarksViewModel();

            if (User.IsInRole("Intern"))
            {
                var themeMarksDto = _themeMarkService.GetThemeMarksByUserId(currentId);
                marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(themeMarksDto);
                var examMarksDto = _examMarkService.GetExamMarksByUserId(currentId);
                marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(examMarksDto);
                person.Marks = marks;
                userListProfile.UserProfile = person;

                return View("../DashBoard/Index", userListProfile);
            }
            else if (User.IsInRole("Menthor") || User.IsInRole("Admin"))
            {
                var themeMarksDto = _themeMarkService.GetThemeMarks();
                marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(themeMarksDto);
                var examMarksDto = _examMarkService.GetExamMarks();
                marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(examMarksDto);

                person.Marks = marks;

                if (User.IsInRole("Admin"))
                {
                    var usersDto = _userService.GetUsersDetails();
                    
                    userListProfile.UserProfile = person;
                    userListProfile.Users = _mapper.Map<IList<UserDetailedViewModel>>(usersDto);

                    return View("../DashBoard/Index", userListProfile);
                }

                userListProfile.UserProfile = person;
                return View("../DashBoard/Index", userListProfile);
            }
            return View("Error");
        }

        [HttpGet]
        [Authorize(Roles ="Menthor, Admin")]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDto = _userService.GetUserById((long)id);
            var user = _mapper.Map<UserDetailedViewModel>(userDto);
            var userdata = new UserProfileViewModel();
            userdata.PersonalData = user;
            userdata.Marks = new MarksViewModel();

            var modules = _moduleService.GetModules();
            userdata.Modules = _mapper.Map<IList<ModuleViewModel>>(modules);

            var tmarks = _themeMarkService.GetThemeMarksByUserId((long)id);
            var emarks = _examMarkService.GetExamMarksByUserId((long)id);

            userdata.Marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(tmarks);
            userdata.Marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(emarks);

            if (userdata == null)
            {
                return NotFound();
            }

            return View("../DashBoard/Details", userdata);
        }
    }
}
