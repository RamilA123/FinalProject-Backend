using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly ISliderService _sliderService;
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly IProductService _productService;
        private readonly ITagService _tagService;
        private readonly IBlogService _blogService;

        public DashboardController(ICategoryService categoryService, 
                                   ISliderService sliderService, 
                                   IBannerService bannerService,
                                   IBannerInfoService bannerInfoService,
                                   IProductService productService,
                                   ITagService tagService,
                                   IBlogService blogService)
        {
            _categoryService = categoryService;
            _sliderService = sliderService;
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _productService = productService;
            _tagService = tagService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _categoryService.GetAllAsync();

            IEnumerable<Slider> sliders = await _sliderService.GetAllAsync();

            List<Banner> banners = await _bannerService.GetAllAsync();

            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();

            IEnumerable<Product> products = await _productService.GetAllAsync();

            List<Blog_> blogs = await _blogService.GetAllAsync();

            List<Tag> tags = await _tagService.GetAllAsync();


            DashboardVM dashboard = new()
            {
                Categories = categories,
                Sliders = sliders,
                Banners = banners,
                BannerInfos = bannerInfos,
                Products = products,
                Blogs = blogs,
            };

            return View(dashboard);
        }
    }
}
