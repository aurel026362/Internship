using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using Microsoft.AspNetCore.Identity;
using App.Web.ViewModels;

namespace App.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MyAppContext _context;

        public UserController(UserManager<User> groupManager, SignInManager<User> signInManager)
        {
            _userManager = groupManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var username = model.EMail;
                var password = model.Password;

                //// добавляем пользователя
                //var result = await _userManager.CreateAsync(user);
                //if (result.Succeeded)
                //{
                //    // установка куки
                //    await _signInManager.SignInAsync(user, false);
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    foreach (var error in result.Errors)
                //    {
                //        ModelState.AddModelError(string.Empty, error.Description);
                //    }
                //}
            }
            return View(model);
        }
    }
}
