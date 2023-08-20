using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.BannerInfo;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Models;
using OrganiDb.Services;
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
            List<BannerInfoVM> bannerInfos = new();

            List<BannerInfo> dbBannerInfos = await _bannerInfoService.GetAllAsync();

            foreach (BannerInfo bannerInfo in dbBannerInfos)
            {
                bannerInfos.Add(new BannerInfoVM
                {
                    Id = bannerInfo.Id,
                    Title = bannerInfo.Title,
                    Description = bannerInfo.Description
                });
            }

            return View(bannerInfos);
        }
    }
}
