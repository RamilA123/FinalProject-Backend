﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly ISocialMediaService _socialMediaService;

        public BlogController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ISocialMediaService socialMediaService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _socialMediaService = socialMediaService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();

            BlogVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                SocialMedias = socialMedias
            };

            return View(model);
        }
    }
}
