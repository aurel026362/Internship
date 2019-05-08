using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.User;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.UserViewModel;
using App.Web.Models.ViewModel.UserViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, SignInManager<User> signInManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserDetailedViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userDto = _mapper.Map<UserDetailedDto>(userViewModel);
            _userService.UpdateUser(userDto);

            return Redirect("~/Admin/Index");
        }

        [HttpPost]
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
            //_userService.Save();
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult DeleteUser(long userId)
        {
            //_userService.DeleteUser(userId);

            return RedirectToAction("Index", "~/Admin/Index");
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