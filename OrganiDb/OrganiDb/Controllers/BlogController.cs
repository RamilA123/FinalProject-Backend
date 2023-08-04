using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Blog;
using OrganiDb.ViewModels.Home;
using OrganiDb.ViewModels.Shop;

namespace OrganiDb.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;

        public BlogController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            BlogVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos
            };

            return View(model);
        }
    }
}
