using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Home;
using System.Diagnostics;

namespace OrganiDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;

        public HomeController(IBannerService bannerService, 
                              IBannerInfoService bannerInfoService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            HomeVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos
            };

            return View(model);
        }
    }
}