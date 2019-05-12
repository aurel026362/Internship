using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.Interfaces.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    [Authorize(Roles = "Intern, Menthor, Admin")]
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public ExamController(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }
        
    }
}