using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Repository;
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
using App.Web.Models.ForMenthor;
using App.Web.Models.ForUser;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    [Authorize]
    public class MenthorController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IInternAchievements _internAchievements;
        private readonly IUserService _userService;
        private readonly IContentInternshipService _contentInternshipService;
        private readonly IMapper _mapper;

        public MenthorController(SignInManager<User> signInManager, IMapper mapper,
            IInternAchievements internAchievements, IUserService userService, IContentInternshipService contentInternshipService)
        {
            _signInManager = signInManager;
            _internAchievements = internAchievements;
            _userService = userService;
            _contentInternshipService = contentInternshipService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Menthor")]
        public async Task<IActionResult> Index()
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
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetTMarksSorted(string orderby, bool sorting)
        {
            var list = _internAchievements.GetThemeMarksSorted(0, orderby, sorting);
            var listViewModel = _mapper.Map<IList<ThemeMarkViewModel>>(list);

            return Json(listViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetMoreTMarks(int page, string orderby, bool sorting)
        {

            var list = _internAchievements.GetThemeMarksSorted(page, orderby, sorting);
            var listViewModel = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            return Json(listViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetTMarksByEmail(string email)
        {
            var listDto = _internAchievements.GetTMarksByEmail(email);
            var list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);

            return Json(list);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetTMarksByModule(long moduleId, string orderby, bool sorting)
        {
            IList<ThemeMarkViewModel> list = null;

            if (moduleId != 0)
            {
                var listDto = _internAchievements.GetThemeMarksByModuleId(moduleId);
                list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            }
            else
            {
                var listDto = _internAchievements.GetThemeMarksSorted(0, orderby, sorting);
                list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            }

            return Json(list);
        }

        [HttpGet]
        [Authorize(Roles ="Menthor, Admin")]
        public async Task<IActionResult> GetTMarksByUserId(long userId)
        {
            var listDto = _internAchievements.GetThemeMarksByUserId(userId);
            var list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            return PartialView(list);
        }
    }
}