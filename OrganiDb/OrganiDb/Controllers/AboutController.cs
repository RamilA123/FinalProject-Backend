﻿using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
