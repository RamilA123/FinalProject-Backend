using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Banner;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {

        private readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IActionResult> Index()
        {
            List<BannerVM> banners = new();

            List<Banner> dbBanners = await _bannerService.GetAllAsync();

            foreach (Banner banner in dbBanners)
            {
                banners.Add(new BannerVM
                {
                    Id = banner.Id,
                    Image = banner.Image,
                });
            }

            return View(banners);
        }
    }
}
