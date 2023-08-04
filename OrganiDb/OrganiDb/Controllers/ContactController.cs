using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.About;
using OrganiDb.ViewModels.Contact;
using OrganiDb.ViewModels.Shop;

namespace OrganiDb.Controllers
{
    public class ContactController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;

        public ContactController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            ContactVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos
            };

            return View(model);
        }
    }
}
