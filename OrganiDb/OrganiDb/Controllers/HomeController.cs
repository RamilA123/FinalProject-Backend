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
        private readonly ISliderService _sliderService;
        private readonly IAssistanceService _assistanceService;
        private readonly ICategoryService _categoryService;

        public HomeController(IBannerService bannerService, 
                              IBannerInfoService bannerInfoService,
                              ISliderService sliderService,
                              IAssistanceService assistanceService,
                              ICategoryService categoryService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _sliderService = sliderService;
            _assistanceService = assistanceService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            IEnumerable<Slider> sliders = await _sliderService.GetAllAsync();
            IEnumerable<Assistance> assistances = await _assistanceService.GetAllAsync();
            List<Category> categories = await _categoryService.GetAllAsync();

            HomeVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Sliders = sliders,
                Assistances = assistances,
                Categories = categories
            };

            return View(model);
        }
    }
}