using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels;
using OrganiDb.Areas.Admin.ViewModels.Banner;
using OrganiDb.Areas.Admin.ViewModels.BannerInfo;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Slider;
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
        private readonly IAssistanceService _assistanceService;
        private readonly IAboutService _aboutService;

        public DashboardController(ICategoryService categoryService, 
                                   ISliderService sliderService, 
                                   IBannerService bannerService,
                                   IBannerInfoService bannerInfoService,
                                   IProductService productService,
                                   ITagService tagService,
                                   IBlogService blogService,
                                   IAssistanceService assistanceService,
                                   IAboutService aboutService)
        {
            _categoryService = categoryService;
            _sliderService = sliderService;
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _productService = productService;
            _tagService = tagService;
            _blogService = blogService;
            _assistanceService = assistanceService;
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            List<CategoryVM> categories = new();

            List<Category> dbCategories = await _categoryService.GetAllAsync();

            foreach (Category category in dbCategories)
            {
                categories.Add(new CategoryVM
                {
                    Id = category.Id,
                    Image = category.Image,
                    Name = category.Name,
                    ProductCount = category.Products.Count
                });
            }

            List<SliderVM> sliders = new();

            IEnumerable<Slider> dbSliders = await _sliderService.GetAllAsync();

            foreach (Slider slider in dbSliders)
            {
                sliders.Add(new SliderVM
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Status = slider.Status,
                    Logo = slider.Logo,
                    Text = slider.Text,
                    Title = slider.Title,
                    Description = slider.Description,
                });
            }

            List<BannerVM> banners = new();

            List<Banner> dbBanners = await _bannerService.GetAllAsync();

            foreach (Banner banner in dbBanners)
            {
                banners.Add(new BannerVM
                {
                    Id = banner.Id,
                    Image = banner.Image,
                });
            }

            List<BannerInfoVM> bannerInfos = new();

            List<BannerInfo> dbBannerInfos = await _bannerInfoService.GetAllAsync();

            foreach (BannerInfo bannerInfo in dbBannerInfos)
            {
                bannerInfos.Add(new BannerInfoVM
                {
                    Id = bannerInfo.Id,
                    Title = bannerInfo.Title,
                    Description = bannerInfo.Description
                });
            }

            IEnumerable<Product> products = await _productService.GetAllAsync();

            List<Blog_> blogs = await _blogService.GetAllAsync();

            IEnumerable<Assistance> assistances = await _assistanceService.GetAllAsync();

            About_ about = await _aboutService.GetAsync();

            List<Tag> tags = await _tagService.GetAllAsync();


            DashboardVM dashboard = new()
            {
                Categories = categories,
                Sliders = sliders,
                Banners = banners,
                BannerInfos = bannerInfos,
                Products = products,
                Blogs = blogs,
                Assistances = assistances,
                About = about
            };

            return View(dashboard);
        }
    }
}
