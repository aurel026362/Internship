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
        private readonly UserManager<RequestedUser> _userManager;
        private readonly SignInManager<RequestedUser> _signInManager;

        public AccountController(UserManager<RequestedUser> groupManager, SignInManager<RequestedUser> signInManager)
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
        public async Task<IActionResult> Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var role = model.Role;
                //User user = new User()
                //{
                //    FirstName = model.FirstName,
                //    LastName = model.LastName,
                //    DateOfBirth = model.DateOfBirth,
                //    PhoneNumber = model.PhoneNumber,
                //    PasswordHash = model.Password,
                //    Email = model.Email,
                //    UserName = model.Email+role
                //};
                RequestedUser user = new RequestedUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    PhoneNumber = model.PhoneNumber,
                    PasswordHash = model.Password,
                    Email = model.Email,
                    UserName = model.Email,
                    TypeUser = model.TypeUser
                };

                // добавляем пользователя
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
