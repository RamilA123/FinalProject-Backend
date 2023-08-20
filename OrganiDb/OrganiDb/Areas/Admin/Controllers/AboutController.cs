using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.About;
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
            AboutVM about = new();

            About_ dbAbout = await _aboutService.GetAsync();

            about.Id = dbAbout.Id;
            about.Title = dbAbout.Title;
            about.Description = dbAbout.Description;
            
            return View(about);
        }
    }
}
