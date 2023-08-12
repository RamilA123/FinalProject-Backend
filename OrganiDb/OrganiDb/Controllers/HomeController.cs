using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Home;
using System.Data.Common;
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
        private readonly IProductService _productService;
        private readonly IDiscountService _discountService;
        private readonly IBrandService _brandService;
        private readonly ICustomerService _customerService;
        private readonly IBlogService _blogService;

        public HomeController(IBannerService bannerService, 
                              IBannerInfoService bannerInfoService,
                              ISliderService sliderService,
                              IAssistanceService assistanceService,
                              ICategoryService categoryService,
                              IProductService productService,
                              IDiscountService discountService,
                              IBrandService brandService,
                              ICustomerService customerService,
                              IBlogService blogService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _sliderService = sliderService;
            _assistanceService = assistanceService;
            _categoryService = categoryService;
            _productService = productService;
            _discountService = discountService;
            _brandService = brandService;
            _customerService = customerService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            IEnumerable<Slider> sliders = await _sliderService.GetAllAsync();
            IEnumerable<Assistance> assistances = await _assistanceService.GetAllAsync();
            List<Category> categories = await _categoryService.GetAllAsync();
            IEnumerable<Product> products = await _productService.GetAllAsync();
            Discount discount = await _discountService.GetAsync();
            List<Brand> brands = await _brandService.GetAllAsync();
            IEnumerable<Customer> customers = await _customerService.GetAllAsync();
            List<Blog_> blogs = await _blogService.GetAllAsync();


            int productCount = products.Count();

            ViewBag.productCount = productCount;

            HomeVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Sliders = sliders,
                Assistances = assistances,
                Categories = categories,
                Products = products,
                Discount = discount,
                Brands = brands,
                Customers = customers,
                Blogs = blogs.Take(3).ToList()
            };

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> ShowMoreOrLessForFeatured(int skip)
        {
            IEnumerable<Product> dbPorducts = await _productService.GetAllAsync();

            dbPorducts = dbPorducts.OrderByDescending(m => m.Id).Skip(skip).Take(4).ToList();

            return PartialView("_ProductsPartial", dbPorducts);
        }

        [HttpGet]
        public async Task<IActionResult> ShowMoreOrLessForSale(int skip)
        {
            IEnumerable<Product> dbPorducts = await _productService.GetAllAsync();

            dbPorducts = dbPorducts.OrderByDescending(m => m.SaleCount).Skip(skip).Take(4).ToList();

            return PartialView("_ProductsPartial", dbPorducts);
        }

        [HttpGet]
        public async Task<IActionResult> ShowMoreOrLessForRated(int skip)
        {
            IEnumerable<Product> dbPorducts = await _productService.GetAllAsync();

            dbPorducts = dbPorducts.OrderByDescending(m => m.Rating.RatingCount).Skip(skip).Take(4).ToList();

            return PartialView("_ProductsPartial", dbPorducts);
        }
    }
}