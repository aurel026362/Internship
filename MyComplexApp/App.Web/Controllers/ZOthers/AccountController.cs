using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers.ZOthers
{
    //[Authorize]
    //public class AccountController : Controller
    //{
    //    private readonly UserManager<User> _userManager;
    //    private readonly SignInManager<User> _signInManager;
    //    private readonly MyAppContext _context;

    //    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, MyAppContext context, IHttpContextAccessor httpContextAccessor)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //        _context = context;


    //        //var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}