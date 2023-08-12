﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Helpers;
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
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        private readonly ICategoryService _categoryService;

        public BlogController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              ISocialMediaService socialMediaService,
                              IBlogService blogService,
                              ITagService tagService,
                              ICategoryService categoryService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _socialMediaService = socialMediaService;
            _blogService = blogService;
            _tagService = tagService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<Banner> banners = await _bannerService.GetAllAsync();

            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            List<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();

            List<Category> categories = await _categoryService.GetAllAsync();

            List<Tag> tags = await _tagService.GetAllAsync();

            List<Blog_> blogs = await _blogService.GetPaginatedDatasAsync(page, take);

            int blogCount = await _blogService.GetCountAsync();

            int totalPage = (int) Math.Ceiling((decimal)blogCount / take);

            Pagination<Blog_> paginatedBlogs = new(blogs,page,totalPage);
                
           
            BlogVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                SocialMedias = socialMedias,
                PaginatedBlogs = paginatedBlogs,
                Categories = categories,
                Tags = tags,
            };

            return View(model);
        }
    }
}
