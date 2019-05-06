using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class RoleController : Controller
    {
        //private readonly ICommentService _commentService;
        //private readonly IMapper _mapper;

        //public CommentController(ICommentService commentService, IMapper mapper)
        //{
        //    _commentService = commentService;
        //    _mapper = mapper;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}