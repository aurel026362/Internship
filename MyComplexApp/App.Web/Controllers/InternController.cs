using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Web.Models.ForIntern;
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

            IList<string> list = await _context.Modules.Select(x => x.Name).ToListAsync();
            ViewData["Modules"] = list;

            var res = await _context.ThemeMarks.Select(x => new InternMarks
            {
                TName = x.theme.Name,
                Mark = x.Mark,
                Comment = x.Comment,
                Id = x.Intern.User.Id
            }).Where(x => x.Id == currentId).ToListAsync();


            return View(res);
        }
        
    }
}