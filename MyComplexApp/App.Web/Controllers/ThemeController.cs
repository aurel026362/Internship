using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using App.Web.Model.ViewModel.ThemeViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class ThemeController : Controller
    {
        private readonly IThemeService _themeService;
        private readonly IMapper _mapper;

        public ThemeController(IThemeService themeService, IMapper mapper)
        {
            _themeService = themeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Menthor, Admin")]
        public async Task<IActionResult> GetThemesByModuleId(long moduleId)
        {
            var listDto = _themeService.GetThemesByModuleId(moduleId);
            var list = _mapper.Map<IList<ThemeViewModel>>(listDto);

            return Json(list);
        }
    }
}