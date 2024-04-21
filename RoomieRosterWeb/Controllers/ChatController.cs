﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DwellDuo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DwellDuo.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var userInfo = new UserDto() { Username= HttpContext.Request.Cookies["UserName"] };

            return View(userInfo);
        }
    }
}

