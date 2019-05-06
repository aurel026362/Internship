using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;
        private readonly IMapper _mapper;

        public ModuleController(IModuleService moduleService, IMapper mapper)
        {
            _moduleService = moduleService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}