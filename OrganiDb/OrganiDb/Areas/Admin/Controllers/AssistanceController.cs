using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Assistance;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Models;
using OrganiDb.Services;
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
            List<AssistanceVM> assistances = new();

            IEnumerable<Assistance> dbAssistances = await _assistanceService.GetAllAsync();

            About_ about = await _aboutService.GetAsync();

            foreach (Assistance assistance in dbAssistances)
            {
                assistances.Add(new AssistanceVM
                {
                    Id = assistance.Id,
                    Image = assistance.Image,
                    Title = assistance.Title,
                    Description = assistance.Description,
                    About = assistance.About.Title,
                });
            }

            return View(assistances);
        }
    }
}
