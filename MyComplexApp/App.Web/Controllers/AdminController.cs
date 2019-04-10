using App.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    public class AdminController : Controller
    {
        MyAppContext _context;
        RoleManager<IdentityRole> _roleManager;

        public AdminController(MyAppContext context, RoleManager<IdentityRole> manager)
        {
            _context = context;
            _roleManager = manager;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();

            return View(users);
        }

        public IActionResult GetRoles()
        {
            return View(_roleManager.Roles.ToList());
        }
    }
}
