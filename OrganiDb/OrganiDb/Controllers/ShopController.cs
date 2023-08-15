﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Home;
using OrganiDb.ViewModels.Shop;
using System.Collections.Generic;

namespace OrganiDb.Controllers
{
    public class ShopController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IRatingService _ratingService;
        private readonly ITagService _tagService;
        private readonly IBrandService _brandService;


        public ShopController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              IProductService productService,
                              ICategoryService categoryService,
                              IRatingService ratingService,
                              ITagService tagService,
                              IBrandService brandService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _productService = productService;
            _categoryService = categoryService;
            _ratingService = ratingService;
            _tagService = tagService;
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchText, int page = 1, int take = 15)
        {
            IEnumerable<Product> products;

            if (searchText != null)
            {
                products = await _productService.GetAllAsync();

                products = products.Where(m => m.Name.ToLower().Contains(searchText.ToLower())).ToList();
            }
            else{

                products = await _productService.GetPaginatedDatasAsync(page, take);
            }
                
            List<Banner> banners = await _bannerService.GetAllAsync();

            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            List<Category> categories = await _categoryService.GetAllAsync();

            IEnumerable<Rating> ratings = await _ratingService.GetAllAsync();

            List<Tag> tags = await _tagService.GetAllAsync();

            List<Brand> brands = await _brandService.GetAllAsync();

            int productCount = await _productService.GetCountAsync();

            int totalPage = (int)Math.Ceiling((decimal)productCount / take);

            Pagination<Product> paginatedProducts = new(products, page, totalPage);


            ShopVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                PaginatedProducts = paginatedProducts,
                Categories = categories,
                Ratings = ratings,
                Tags = tags,
                Brands = brands
            };
                
            return View(model);
            
        }
    }
}
