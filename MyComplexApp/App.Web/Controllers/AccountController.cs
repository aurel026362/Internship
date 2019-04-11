using App.Data.Domain.DomainModels.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Concrete;
using App.Web.ViewModels;
using App.Data.Context;
using System;

namespace App.Web.Controllers
{ 
    
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> groupManager, SignInManager<User> signInManager)
        {
            _userManager = groupManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
