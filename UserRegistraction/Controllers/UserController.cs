﻿using Microsoft.AspNetCore.Mvc;

namespace UserRegistraction.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
