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
        private readonly ICityService _cityService;

        public ContactController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ILayoutService layoutService,
                              ICityService cityService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _layoutService = layoutService;
            _cityService = cityService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            LayoutVM data = await _layoutService.GetAllDatasAsync();
            List<City> cities = await _cityService.GetAllAsync();

            ContactVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Data = data,
                Cities = cities
            };

            return View(model);
        }
    }
}
