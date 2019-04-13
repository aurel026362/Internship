using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Repository;
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
            //var user = _userManager.FindByEmailAsync();
            return View(_context.ThemeMarks.ToList());
        }
    }
}