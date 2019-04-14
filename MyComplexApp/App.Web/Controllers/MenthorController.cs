using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Repository;
using App.Web.Models.ForMenthor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    [Authorize(Roles = "Menthor")]
    public class MenthorController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MyAppContext _context;

        public MenthorController(UserManager<User> groupManager, SignInManager<User> signInManager, MyAppContext context)
        {
            _userManager = groupManager;
            _signInManager = signInManager;
            _context = context;


            //var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public IActionResult Index()
        {
            var interns = _context.ThemeMarks.Select(x => new InternAllMarks()
            {
                Id = x.Intern.UserId,
                FirstName = x.Intern.User.FirstName,
                LastName = x.Intern.User.LastName,
                EMail = x.Intern.User.Email,
                Theme = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return View(interns/*_context.ThemeMarks.ToList()*/);
        }
    }
}