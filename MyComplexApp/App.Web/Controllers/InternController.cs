using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Web.Models.ForIntern;
using App.Web.Models.ForUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            var mark = new Mark();
            mark.ThemeMarks = currentTMarks;
            mark.ExamMarks = currentEMarks;
            person.Marks = mark;

            person.Modules = await _context.Modules.ToListAsync();

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
        
        public IActionResult EditData(string FName=""/*, string LName, string newPhone, string DBirth*/)
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            //var user = await _context.Users.FindAsync(currentId);
            //user.FirstName = FName;
            //user.LastName = LName;
            //user.PhoneNumber = newPhone;
            //user.DateOfBirth = Convert.ToDateTime(DBirth);
            //_context.Update(user);
            //_context.SaveChanges();
            return PartialView(null);
        }
        
    }
}