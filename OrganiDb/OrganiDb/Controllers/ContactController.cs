using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;
using OrganiDb.ViewModels.About;
using OrganiDb.ViewModels.Contact;
using OrganiDb.ViewModels.Shop;

namespace OrganiDb.Controllers
{
    public class ContactController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly ILayoutService _layoutService;

        public ContactController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ILayoutService layoutService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _layoutService = layoutService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            LayoutVM data = await _layoutService.GetAllDatasAsync();

            ContactVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Data = data
            };

            return View(model);
        }
    }
}
