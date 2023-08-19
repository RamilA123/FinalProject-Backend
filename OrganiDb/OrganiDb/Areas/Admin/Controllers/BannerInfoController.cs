using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerInfoController : Controller
    {
        private readonly IBannerInfoService _bannerInfoService;

        public BannerInfoController(IBannerInfoService bannerinfoService)
        {
            _bannerInfoService = bannerinfoService;
        }
        public async Task<IActionResult> Index()
        {
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            return View(bannerInfos);
        }
    }
}
