using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Repository;
using App.Web.Models.ForMenthor;
using App.Web.Models.ForUser;
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

        public async Task<IActionResult> Index()
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var menthorData = new MenthorData();

            menthorData.PersonalData = await _context.Users.Where(x => x.Id.Equals(currentId)).Select(x => new PersonalData()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                EMail = x.Email,
                PhoneNumber = x.PhoneNumber,
                DateOfBirth = x.DateOfBirth
            }).FirstAsync();


            menthorData.InternMarks = _context.ThemeMarks.Select(x => new InternAllMarks()
            {
                Id = x.Intern.UserId,
                FirstName = x.Intern.User.FirstName,
                LastName = x.Intern.User.LastName,
                EMail = x.Intern.User.Email,
                Theme = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment
            }).ToList();

            return View(menthorData);
        }
    }
}