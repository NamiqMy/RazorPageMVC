﻿using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
