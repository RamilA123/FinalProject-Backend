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

        private readonly AppDbContext _context;
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly ITeamFarmerService _teamFarmerService;

        public AboutController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ITeamFarmerService teamFarmerService,
                              AppDbContext context)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _teamFarmerService = teamFarmerService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<TeamFarmer> teamFarmers = await _teamFarmerService.GetAllWithIncludesAsync();
            List<TeamFarmerSocialMedia> teamsSocialmedias = await _context.TeamFarmerSocialMedias.Include(m => m.SocialMedia).ToListAsync();

            AboutVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                TeamFarmers = teamFarmers
            };

            return View(model);
        }
    }
}
