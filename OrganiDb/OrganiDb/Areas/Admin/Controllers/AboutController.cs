using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            About_ about = await _aboutService.GetAsync();

            return View(about);
        }
    }
}
