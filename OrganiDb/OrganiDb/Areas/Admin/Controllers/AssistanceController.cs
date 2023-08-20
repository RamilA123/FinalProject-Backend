using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AssistanceController : Controller
    {
        private readonly IAssistanceService _assistanceService;
        private readonly IAboutService _aboutService;

        public AssistanceController(IAssistanceService assistanceService, IAboutService aboutService)
        {
            _assistanceService = assistanceService;
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Assistance> assistances = await _assistanceService.GetAllAsync();

            About_ about = await _aboutService.GetAsync();

            return View(assistances);
        }
    }
}
