using Microsoft.AspNetCore.Mvc;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;

namespace OrganiDb.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILayoutService _layoutService;

        public ProfileController(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task <IActionResult> Index()
        {
            LayoutVM datas = await _layoutService.GetAllDatas();

            return View(datas);
        }
    }
}
