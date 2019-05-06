using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Models.ComplexViewModel.Admin;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ViewModel.UserViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    //[Authorize(Roles = ("Admin"))]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MyAppContext _context;
        private readonly IUserService _userService;
        private readonly ICommentService _commentService;
        private readonly IEMarkService _examMarkService;
        private readonly IExamService _examService;
        private readonly IGroupService _groupService;
        private readonly IModuleService _moduleService;
        private readonly IThemeService _themeService;
        private readonly ITMarkService _themeMarkService;
        private readonly IMapper _mapper;

        public AdminController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper,
            IUserService userService,
            ICommentService commentService,
            IEMarkService emarkService,
            IExamService examService,
            IGroupService groupService,
            IModuleService moduleService,
            IThemeService themeService,
            ITMarkService themeMarkService,
            MyAppContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Index()
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new AdminDataViewModel();
            person.Data = new CurrentUserDataViewModel();
            var user = _userService.GetUserById(currentId);
            person.Data.PersonalData = _mapper.Map<UserDetailedViewModel>(user);

            var marks = new MarksViewModel();
            var currentTMarks = _themeMarkService.GetThemeMarks();
            marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(currentTMarks);
            var currentEMarks = _examMarkService.GetExamMarks();
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(currentEMarks);
            person.Data.Marks = marks;
            marks.AvgTMarks = _themeMarkService.GetAvgTMarks();

            var modules = _moduleService.GetModules();
            person.Data.Modules = _mapper.Map<IList<ModuleViewModel>>(modules);

            var themes = _themeService.GetThemes();
            person.Data.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _commentService.GetComments();
            person.Data.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            var usersDto = _userService.GetUsersDetails();
            person.Users = _mapper.Map<IList<UserDetailedViewModel>>(usersDto);

            return View(person);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDto = _userService.GetUserById((long)id);
            var user = _mapper.Map<UserDetailedViewModel>(userDto);

            ////-------------
            //var userDomen = _mapper.Map<User>(user);
            //var roles = await _userManager.GetRolesAsync(userDomen);
            //user.Role = roles[0];

            //var alldatauser = new UserAndMarksViewModel();
            var userdata = new CurrentUserDataViewModel();
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

            return View(userdata);
        }

        [HttpPost]
        public IActionResult DeleteUser(long userId)
        {
            //_userService.DeleteUser(userId);

            return RedirectToAction("Index", "~/Admin/Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserDetailedViewModel userViewModel)
        {
            var userDto = _mapper.Map<UserDetailedDto>(userViewModel);
            _userService.UpdateUser(userDto);

            return Redirect("~/Admin/Index");
        }

    }
}
