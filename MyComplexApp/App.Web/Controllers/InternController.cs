using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Services.Interfaces;
using App.Web.Model.ViewModel.CommentViewModel;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ModuleViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Model.ViewModel.ThemeViewModel;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ComplexViewModel.Intern;
using App.Web.Models.GeneralUser;
using App.Web.Models.ViewModel.ThemeViewModel;
using App.Web.TEST;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace App.Web.Controllers
{
    [Authorize(Roles = "Intern")]
    public class InternController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MyAppContext _context;
        private readonly IInternAchievements _internAchievements;
        private readonly IMapper _mapper;

        public InternController(UserManager<User> userManager, SignInManager<User> signInManager, MyAppContext context, IInternAchievements internAchievements, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _internAchievements = internAchievements;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var person = new CurrentDataInternViewModel();
            var user = _internAchievements.GetUserById(currentId);

            person.PersonalData = _mapper.Map<UserViewModel>(user);

            var currentTMarks = _internAchievements.GetThemeMarksByUserId(currentId);

            var marks = new MarksViewModel();

            marks.ThemeMarks = _mapper.Map<IList<ThemeMarkViewModel>>(currentTMarks);

            var currentEMarks = _internAchievements.GetExamMarksByUserId(currentId);
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(currentEMarks);

            person.Marks = marks;

            var modules = _internAchievements.GetModules();
            person.Modules = _context.Modules//_mapper.Map<IList<ModuleViewModel>>(modules);
                .Select(x => new ModuleViewModel()
                {
                    Name = x.Name,
                    Id = x.Id,
                    DateStart = x.DateStart
                }).ToList();

            var themes = _internAchievements.GetThemes();
            person.Themes = _mapper.Map<IList<ThemeViewModel>>(themes);

            var comments = _internAchievements.GetComments();
            person.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return View(person);
        }

        public async Task<IActionResult> GetMarks(long moduleId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            IList<ThemeMarkViewModel> tmarks;

            if (!moduleId.Equals(0))
            {
                var list = _internAchievements.GetThemeMarksByUserId(currentId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }
            else
            {
                var list = _internAchievements.GetThemeMarks(currentId, moduleId);
                tmarks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }

            return PartialView("GetMarks", tmarks);
        }

        [HttpGet]
        public async Task<IActionResult> GetComments(long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUser = _internAchievements.GetUserById(currentId);
            //_context.Users.FirstOrDefault(x => x.Id.Equals(currentId));

            var data = new CurrentDataInternViewModel();

            var personaldata = _internAchievements.GetUserById(currentId);
            data.PersonalData = _mapper.Map<UserViewModel>(personaldata);

            var comments = _internAchievements.GetComments(themeId);
            data.Comments = _mapper.Map<IList<CommentViewModel>>(comments);

            return PartialView("GetComments", data);
        }

        [HttpGet]
        public ActionResult GetMoreComments(long themeId, int pageNr)
        {
            var comments = _internAchievements.GetComments(pageNr, themeId);
            var result = JsonConvert.SerializeObject(_mapper.Map<IList<CommentViewModel>>(comments));
            return Content(result, "application/json");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitComment(string comment, long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            _internAchievements.AddComment(currentId, themeId, comment);
            _context.SaveChanges();
            //await _context.Comments.AddAsync(new Comment() { UserId = currentId, Content = comment, DateComment = DateTime.Now, ThemeId = themeId });
            //await _context.SaveChangesAsync();
            return StatusCode(200);
        }

        [HttpPost]
        public async Task<IActionResult> EditData(string fname, string lname, string phone, DateTime dbirth)
        {
            //if (!ModelState.IsValid) { }
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            _internAchievements.UpdateUser(currentId, fname, lname, phone, dbirth);
            //var user = await _context.Users.FindAsync(currentId);
            //user.FirstName = fname;
            //user.LastName = lname;
            //user.PhoneNumber = phone;
            //user.DateOfBirth = dbirth;
            //_context.Update(user);
            //_context.SaveChanges();
            return StatusCode(200);
        }

        [HttpGet]
        public async Task<IActionResult> AddTheme()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTheme(AddThemeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //CreateMap

            var theme = _mapper.Map<Theme>(model);
            _context.Themes.Add(theme);
            _context.SaveChanges();

            return RedirectToAction("Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> AddModule()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddModule(ModuleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Module module = _mapper.Map<Module>(model);
            await _context.Modules.AddAsync(module);
            await _context.SaveChangesAsync();

            return RedirectToAction("~/Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> CheckModule(string Name)
        {
            var result = true;

            var list = _context.Modules.Where(x => x.Name.Equals(Name)).Select(x=>x.Name).FirstOrDefault();

            if (list != null)
            {
                result = false;
                
            }

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> FormExample()
        {
            var m = new MyModel
            {
                Languages = new List<LanguageOption>
                {
                    new LanguageOption
                    {
                        Name = "dsad",
                        IsChecked = false
                    }
                }
            };
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> FormExample(MyModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return Ok();
        }
    }
}