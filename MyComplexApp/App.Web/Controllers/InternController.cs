using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Web.Models.ForIntern;
using App.Web.Models.ForUser;
using App.Web.Models.GeneralUser;
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

        public InternController(UserManager<User> userManager, SignInManager<User> signInManager, MyAppContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            //IList<string> list = await _context.Modules.Select(x => x.Name).ToListAsync();
            //ViewData["Modules"] = list;

            //var res = await _context.ThemeMarks.Select(x => new InternMarks
            //{
            //    TName = x.theme.Name,
            //    Mark = x.Mark,
            //    Comment = x.Comment,
            //    Id = x.Intern.User.Id
            //}).Where(x => x.Id == currentId).ToListAsync();

            var person = new DataCurrentUser();
            
            person.PersonalData = await _context.Users.Where(x => x.Id.Equals(currentId)).Select(x => new PersonalData()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                EMail = x.Email,
                PhoneNumber = x.PhoneNumber,
                DateOfBirth = x.DateOfBirth
            }).FirstAsync();

            var currentTMarks = await _context.ThemeMarks.Where(x=>x.Intern.User.Id.Equals(currentId)).Select(x => new InternTMark()
            {
                TName = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToListAsync();

            var currentEMarks = await _context.ExamMarks.Where(x => x.Intern.User.Id.Equals(currentId)).Select(x => new InternExamMark()
            {
                ModuleName = x.Exam.Module.Name,
                Mark = x.Mark,
                Comment = x.Comment,
                Date = x.Exam.Date
            }).ToListAsync();

            var mark = new Marks();
            mark.ThemeMarks = currentTMarks;
            mark.ExamMarks = currentEMarks;
            person.Marks = mark;

            person.Modules = await _context.Modules.ToListAsync();

            person.Themes = await _context.Themes.ToListAsync();

            person.CurrentUserComms = new CurrentUserCommsViewModel();

            person.CurrentUserComms.Comments = await _context.Comments.Select(x => new CommentsViewModel
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Comment = x.Content,
                DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
            }).Take(10).OrderByDescending(x => x.DateComment).ToListAsync();

            //person.CurrentUserComms.Comments = cms;
            person.CurrentUserComms.CurrentUserEmail = person.PersonalData.EMail;

            return View(person);
        }

        public async Task<IActionResult> GetMarks(long moduleId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            
            List<InternTMark> marks;
            
            if (!moduleId.Equals(0))
            {
                marks = _context.ThemeMarks
                    .Where(x => x.theme.ModuleId.Equals(moduleId) && x.Intern.UserId.Equals(currentId)).Select(x => new InternTMark
                {
                    TName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).ToList();
            }
            else {
                marks = await _context.ThemeMarks.Where(x => x.Intern.UserId.Equals(currentId)).Select(x => new InternTMark
                {
                    TName = x.theme.Name,
                    Mark = x.Mark,
                    Comment = x.Comment
                }).ToListAsync();
            }

            return PartialView("GetMarks", marks);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetComments(long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var currentUser = _context.Users.FirstOrDefault(x=>x.Id.Equals(currentId));

            var data = new CurrentUserCommsViewModel();

            data.CurrentUserEmail = currentUser.Email;
             data.Comments = await _context.Comments.Where(x => x.ThemeId.Equals(themeId)).Select(x=>new CommentsViewModel()
             {
                 EMail = x.User.Email,
                 ThemeName = x.Theme.Name,
                 Comment = x.Content,
                 DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
             }).OrderByDescending(x => x.DateComment).Take(10).ToListAsync();

            return PartialView("GetComments", data);
        }

        [HttpGet]
        public ActionResult GetMoreComments(long themeId, int pageNr)
        {
            var comments = _context.Comments.Where(x => x.ThemeId.Equals(themeId)).Select(x => new CommentsViewModel()
            {
                EMail = x.User.Email,
                ThemeName = x.Theme.Name,
                Comment = x.Content,
                DateComment = x.DateComment.ToString("dd/MM/yyyy HH:mm")
            }).OrderByDescending(x => x.DateComment).Skip(10*pageNr).Take(10).ToList();

            //return Json(comments);
            var result = JsonConvert.SerializeObject(comments);
            return Content(result, "application/json");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitComment(string comment, long themeId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            await _context.Comments.AddAsync(new Comment() { UserId=currentId, Content = comment, DateComment = DateTime.Now, ThemeId = themeId});
            await _context.SaveChangesAsync();
            return StatusCode(200);
        }

        [HttpPost]
        public async Task<IActionResult> EditData(string fname, string lname, string phone, DateTime dbirth)
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var user = await _context.Users.FindAsync(currentId);
            user.FirstName = fname;
            user.LastName = lname;
            user.PhoneNumber = phone;
            user.DateOfBirth = dbirth;
            _context.Update(user);
            _context.SaveChanges();
            return StatusCode(200);
        }
        
    }
}