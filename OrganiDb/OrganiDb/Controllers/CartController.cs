﻿using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
