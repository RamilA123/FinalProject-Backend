using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.About;
using OrganiDb.ViewModels.Blog;
using OrganiDb.ViewModels.Shop;

namespace OrganiDb.Controllers
{
    public class AboutController : Controller
    {


        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly ITeamFarmerService _teamFarmerService;
        private readonly IAboutService _aboutService;
        private readonly IBrandService _brandService;
        private readonly ICustomerService _customerService;

        public AboutController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ITeamFarmerService teamFarmerService,
                              IAboutService aboutService,
                              IBrandService brandService,
                              ICustomerService customerService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _teamFarmerService = teamFarmerService;
            _aboutService = aboutService;
            _brandService = brandService;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<TeamFarmer> teamFarmers = await _teamFarmerService.GetAllWithIncludesAsync();
            TeamFarmerHeader teamFarmerHeader = await _teamFarmerService.GetTeamFarmerHeaderDatasAsync();
            List<TeamFarmerSocialMedia> teamFarmerSocialMedias = await _teamFarmerService.GetTeamFarmerSocialMediaDatasAsync();
            About_ about = await _aboutService.GetAsync();
            List<Brand> brands = await _brandService.GetAllAsync();
            IEnumerable<Customer> customers = await _customerService.GetAllAsync();

            AboutVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                TeamFarmers = teamFarmers,
                TeamFarmerHeader = teamFarmerHeader,
                TeamFarmerSocialMedias = teamFarmerSocialMedias,
                About = about,
                Brands = brands,
                Customers = customers.Skip(3).Take(3).ToList()
            };

            return View(model);
        }
    }
}
