using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("signin")]
        public IActionResult SignIn() => View();

        [Route("signin/{provider}")]
        public IActionResult SignIn(string provider, string returnUrl = null) =>
            Challenge(new AuthenticationProperties { RedirectUri = returnUrl ?? "/" }, provider);

        [Route("signout")]
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Test()
        {
            var vm = new ProfileViewModel
            {
                Claims = User.Claims,
                Name = User.Identity.Name
            };
            return View(vm);
        }
    }

    public class ProfileViewModel
    {
        public string Name { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}