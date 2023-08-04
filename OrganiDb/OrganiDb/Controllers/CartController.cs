using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Contact;
using OrganiDb.ViewModels.Home;

namespace OrganiDb.Controllers
{
    public class CartController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;

        public CartController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            CartVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos
            };

            return View(model);
        }
    }
}
