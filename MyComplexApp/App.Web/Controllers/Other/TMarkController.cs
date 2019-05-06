using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class TMarkController : Controller
    {
        private readonly ITMarkService _tMarkService;
        private readonly IMapper _mapper;

        public TMarkController(ITMarkService tMarkService, IMapper mapper)
        {
            _tMarkService = tMarkService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}