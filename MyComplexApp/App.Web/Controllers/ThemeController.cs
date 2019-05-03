using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using AutoMapper;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}