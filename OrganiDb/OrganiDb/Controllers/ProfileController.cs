using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;
using OrganiDb.ViewModels.Profile;

namespace OrganiDb.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILayoutService _layoutService;
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;

        public ProfileController(ILayoutService layoutService,IBannerService banner, IBannerInfoService bannerInfo)
        {
            _layoutService = layoutService;
            _bannerService = banner;
            _bannerInfoService= bannerInfo;
        }

        public async Task <IActionResult> Index()
        {
            LayoutVM data = await _layoutService.GetAllDatas();
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            ProfileVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Data = data
            };

            return View(model);
        }
    }
}
