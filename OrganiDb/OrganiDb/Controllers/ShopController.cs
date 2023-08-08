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

        public ShopController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService,
                              IProductService productService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            IEnumerable<Product> products = await _productService.GetAllAsync();

            ShopVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Products = products
            };

            return View(model);
        }
    }
}
