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
    [Authorize(Roles = "Menthor")]
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

        public async Task<IActionResult> Index()
        {
            //var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            //var menthorData = new MenthorData();

            //menthorData.PersonalData = await _context.Users.Where(x => x.Id.Equals(currentId)).Select(x => new PersonalData()
            //{
            //    Id = x.Id,
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    EMail = x.Email,
            //    PhoneNumber = x.PhoneNumber,
            //    DateOfBirth = x.DateOfBirth
            //}).FirstAsync();


            //menthorData.InternMarks = _context.ThemeMarks.Select(x => new InternAllMarks()
            //{
            //    Id = x.Intern.UserId,
            //    FirstName = x.Intern.User.FirstName,
            //    LastName = x.Intern.User.LastName,
            //    EMail = x.Intern.User.Email,
            //    Theme = x.theme.Name,
            //    Mark = x.Mark,
            //    Comment = x.Comment
            //}).ToList();

            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new CurrentDataInternViewModel();
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
            //.Select(x => new ModuleViewModel()
            //{
            //    Name = x.Name,
            //    Id = x.Id,
            //    DateStart = x.DateStart
            //}).ToList();

            var themes = _contentInternshipService.GetThemes();
            person.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _contentInternshipService.GetComments();
            person.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return View(person);
        }
    }
}