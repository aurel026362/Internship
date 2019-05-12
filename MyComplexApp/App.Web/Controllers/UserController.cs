using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ViewModel.UserViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly MyAppContext _context; 
        private readonly IMapper _mapper;

        public UserController(MyAppContext context, IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize(Roles="Admin")]
        public async Task<IActionResult> AddRequestedUser(long requestedUserId, string role)
        {
            await _userService.AddRequestedUser(requestedUserId, role);
            return Ok();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveRequestedUser(long requestedUserId)
        {
            _userService.DeleteUser(requestedUserId);
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetRequestedUsers()
        {
            var listDto = _userService.GetRequestedUsers();
            var list = _mapper.Map<IList<User>>(listDto);

            //var asd = _userManager.Users.Include(u => u.Roles).Where(x=>x.Roles.Count()==0).ToList();
            //var asdd = _mapper.Map<IList<User>>(asd);
            //foreach(var item in asdd)
            //{
            //    var roles = _userManager.GetRolesAsync(item);
            //}

            //var list = _context.Users.Where(x => x.Id == 6).FirstOrDefault();
            //var roles = _userManager.GetRolesAsync(list);
            return Json(list);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(UserDetailedViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userDto = _mapper.Map<UserDetailedDto>(userViewModel);
            _userService.UpdateUser(userDto);

            return View("~/Home/DashBoard");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditPersonalData(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));
            var user = _userService.GetUserById(currentId);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.DateOfBirth = model.DateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult DeleteUser(long userId)
        {
            _userService.DeleteUser(userId);
            return View("~/Home/DashBoard");
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetInterns()
        {
            var listDto = _userService.GetInterns();
            var list = _mapper.Map<IList<UserViewModel>>(listDto);

            return Json(list);
        }
    }
}