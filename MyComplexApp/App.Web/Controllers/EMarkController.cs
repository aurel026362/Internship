using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class EMarkController : Controller
    {
        private readonly IEMarkService _eMarkService;
        private readonly IMapper _mapper;

        public EMarkController(IEMarkService eMarkService, IMapper mapper)
        {
            _eMarkService = eMarkService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}