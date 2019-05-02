using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces;
using App.Services.Interfaces.ContentInternshipService;
using App.Services.Interfaces.UserService;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.Admin;
using App.Web.Models.ComplexViewModel.Admin;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ComplexViewModel.Intern;
using App.Web.Models.ForUser;
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
    [Authorize(Roles =("Admin"))]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MyAppContext _context;
        private readonly IInternAchievements _internAchievements;
        private readonly IUserService _userService;
        private readonly IContentInternshipService _contentInternshipService;
        private readonly IMapper _mapper;

        public AdminController(UserManager<User> userManager, SignInManager<User> signInManager, MyAppContext context, IMapper mapper,
            IInternAchievements internAchievements, IUserService userService, IContentInternshipService contentInternshipService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _internAchievements = internAchievements;
            _userService = userService;
            _contentInternshipService = contentInternshipService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new AdminDataViewModel();
            person.Data = new CurrentUserDataViewModel();
            var user = _userService.GetUserById(currentId);
            person.Data.PersonalData = _mapper.Map<UserViewModel>(user);
            var currentTMarks = _internAchievements.GetThemeMarks();

            var marks = new MarksViewModel();
            marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(currentTMarks);
            var currentEMarks = _internAchievements.GetExamMarks();
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(currentEMarks);
            person.Data.Marks = marks;
            var modules = _contentInternshipService.GetModules();
            person.Data.Modules = _mapper.Map<IList<ModuleViewModel>>(modules);

            var themes = _contentInternshipService.GetThemes();
            person.Data.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _contentInternshipService.GetComments();
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

            var userDto = _userService.GetUserDetails((long)id);
            var user = _mapper.Map<UserDetailedViewModel>(userDto);

            var alldatauser = new UserAllDataViewModel();
            alldatauser.Details = user;
            alldatauser.Marks = new MarksViewModel();

            var tmarks = _internAchievements.GetThemeMarksByUserId((long) id);
            var emarks = _internAchievements.GetExamMarksByUserId((long)id);

            alldatauser.Marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(tmarks);
            alldatauser.Marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(emarks);
            
            if (alldatauser == null)
            {
                return NotFound();
            }

            return View(alldatauser);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(UserDetailedViewModel userViewModel)
        {
            var userDto = _mapper.Map<UserDetailedDto>(userViewModel);
            var user = _mapper.Map<User>(userDto);
            _context.Update(user);
            return Ok();
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(long id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
