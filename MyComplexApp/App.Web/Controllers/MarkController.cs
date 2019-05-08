﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Domain.DomainModels.Identity;
using App.Services.Dtos.DTOs.ThemeMark;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.ExamMarkViewModel;
using App.Web.Model.ViewModel.ThemeMarkViewModel;
using App.Web.Models.ComplexViewModel.General;
using App.Web.Models.ViewModel.ThemeMarkViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class MarkController : Controller
    {
        private readonly ITMarkService _themeMarkService;
        private readonly IEMarkService _examMarkService;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public MarkController(ITMarkService themeMarkService, IEMarkService examMarkService, SignInManager<User> signInManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _themeMarkService = themeMarkService;
            _examMarkService = examMarkService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetThemeMarks(long userId)
        //{
        //    var listDto = _themeMarkService.GetThemeMarksByUserId(userId);
        //    var list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);

        //    return Json(new
        //    {
        //        themes = list.Select(x => x.ThemeName),
        //        marks = list.Select(x => x.Mark)
        //    });
        //}

        [HttpPost]
        [Authorize(Roles ="Menthor, Admin")]
        public async Task<IActionResult> AddOrUpdateThemeMark(AddThemeMarkViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var markDto = _mapper.Map<AddThemeMarkDto>(model);
            var result = _themeMarkService.AddOrUpdateThemeMark(markDto);

            return Json(result);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetThemeMarksSorted(string orderby, bool sorting)
        {
            var list = _themeMarkService.GetThemeMarksSorted(0, orderby, sorting);
            var listViewModel = _mapper.Map<IList<ThemeMarkViewModel>>(list);

            return Json(listViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetMoreThemeMarks(int page, string orderby, bool sorting)
        {

            var list = _themeMarkService.GetThemeMarksSorted(page, orderby, sorting);
            var listViewModel = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            return Json(listViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetThemeMarksByEmail(string email)
        {
            var listDto = _themeMarkService.GetTMarksByEmail(email);
            var list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);

            return Json(list);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetThemeMarksByModule(long moduleId, string orderby, bool sorting)
        {
            IList<ThemeMarkViewModel> list = null;

            if (moduleId != 0)
            {
                var listDto = _themeMarkService.GetThemeMarksByModuleId(moduleId);
                list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            }
            else
            {
                var listDto = _themeMarkService.GetThemeMarksSorted(0, orderby, sorting);
                list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            }

            return Json(list);
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetThemeMarksByUserId(long userId)
        {
            var listDto = _themeMarkService.GetThemeMarksByUserId(userId);
            var list = _mapper.Map<IList<ThemeMarkViewModel>>(listDto);
            return PartialView(list);
        }

        private IList<ThemeMarkViewModel> GetThemeMarks(long moduleId, long userId)
        {
            IList<ThemeMarkViewModel> marks;

            if (!moduleId.Equals(0))
            {
                var list = _themeMarkService.GetThemeMarks(userId, moduleId);
                marks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }
            else
            {
                var list = _themeMarkService.GetThemeMarksByUserId(userId);
                marks = _mapper.Map<IList<ThemeMarkViewModel>>(list);
            }

            return marks;
        }

        [HttpGet]
        public async Task<IActionResult> GetMarks(long moduleId)
        {
            var currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var thememarks = GetThemeMarks(moduleId, currentId);
            var examMarksDto = _examMarkService.GetExamMarksByUserId(currentId);

            var marks = new MarksViewModel();
            marks.ThemeMarks = thememarks;
            marks.ExamMarks = _mapper.Map<IList<ExamMarkViewModel>>(examMarksDto);
            return Json(marks);
            //return PartialView("_GetMarks", tmarks);
        }

        [HttpGet]
        public async Task<IActionResult> GetThemeMarksByModuleUser(long moduleId, long userId)
        {
            var list = GetThemeMarks(moduleId, userId);

            return Json(list);
        }

        [HttpGet]
        public async Task<IActionResult> GetMarksForChart(long moduleId)
        {
            long currentId = Convert.ToInt32(_signInManager.UserManager.GetUserId(User));

            var themMarksDto = GetThemeMarks(moduleId, currentId);
            var examMarksDto = _examMarkService.GetExamMarksByUserId(currentId);

            return Json(new
            {
                themes = themMarksDto.Select(x => x.ThemeName),
                themeMarks = themMarksDto.Select(x => x.Mark),
                modules = examMarksDto.Select(x => x.ModuleName),
                examMarks = examMarksDto.Select(x => x.Mark)
            });
        }
    }
}