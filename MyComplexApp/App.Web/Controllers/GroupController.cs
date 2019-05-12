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
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public GroupController(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }
        
    }
}