using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.ProductDetail;

namespace OrganiDb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IProductService _productService;
        private readonly IRatingService _ratingService;

        public ProductController(IBannerService bannerService,
                                 IBannerInfoService bannerInfoService,
                                 ISocialMediaService socialMediaService,
                                 IProductService productService,
                                 IRatingService ratingService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _socialMediaService = socialMediaService;
            _productService = productService;
            _ratingService = ratingService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? id)
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();
            Product product = await _productService.GetByIdAsync(id);
            int ratingCount = await _ratingService.GetCountAsync();
            ViewBag.ratingCount = ratingCount;

            ProductVM model = new()
            {    
                Banners = banners,
                BannerInfos = bannerInfos,
                SocialMedias = socialMedias,
                Product = product
            };

            return View(model);
        }
    }
}
