using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Home;
using OrganiDb.ViewModels.Shop;

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

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            IEnumerable<Product> products = await _productService.GetAllAsync();
            List<Category> categories = await _categoryService.GetAllAsync();
            IEnumerable<Rating> ratings = await _ratingService.GetAllAsync();
            List<Tag> tags = await _tagService.GetAllAsync();
            List<Brand> brands = await _brandService.GetAllAsync();

            ShopVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Products = products,
                Categories = categories,
                Ratings = ratings,
                Tags = tags,
                Brands = brands
            };

            return View(model);
        }
    }
}
