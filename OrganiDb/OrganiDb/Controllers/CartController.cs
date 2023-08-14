using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Responses;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Contact;
using OrganiDb.ViewModels.Home;
using System.Collections.Generic;
using System.Text.Json;

namespace OrganiDb.Controllers
{
    public class CartController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _accesssorService;

        public CartController(IBannerService bannerService,
                              IBannerInfoService bannerInfoService, 
                              IBasketService basketService,
                              IProductService productService,
                              IHttpContextAccessor accesssorService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _basketService = basketService;
            _productService = productService;
            _accesssorService = accesssorService;
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<BasketDetailVM> baskets = new List<BasketDetailVM>();

            if (_accesssorService.HttpContext.Request.Cookies["basket"] != null)
            {
                List<BasketVM> existedProducts = JsonSerializer.Deserialize<List<BasketVM>>(_accesssorService.HttpContext.Request.Cookies["basket"]);

                foreach (BasketVM existedProduct in existedProducts)
                {
                    Product product = await _productService.GetByIdWithImagesAsync(existedProduct.Id);
                    baskets.Add(new BasketDetailVM
                    {
                        Id = product.Id,
                        Image = product.ProductImages.Where(m => m.IsMain).FirstOrDefault().Image,
                        Name = product.Name,
                        Description = product.Description,
                        Count = existedProduct.Count,
                        Price = product.ActualPrice,
                        DiscountPrice = product.ActualPrice - (product.ActualPrice * product.Discount.Percent) / 100,
                        Percent = product.Discount.Percent,
                        TotalPrice = product.ActualPrice * existedProduct.Count
                    });
                }
            }

            CartVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Baskets = baskets
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int? id)
        {
            Product product = await _productService.GetByIdAsync(id);

            List<BasketVM> basket = _basketService.GetAllAsync();

            _basketService.AddProduct(basket, product);

            int grandTotalCount = basket.Sum(m => m.Count);

            return Ok(grandTotalCount);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFromCart(int? id)
        {
            BasketDeleteResponse responseProduct = await _basketService.DeleteProduct(id);

            return Ok(responseProduct);
            
        }

        [HttpGet]
        public async Task<IActionResult> IncreaseCount(int? id)
        {
            BasketCountResponse response = await _basketService.IncreaseProductCount(id);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> DecreaseCount(int? id)
        {
            BasketCountResponse response = await _basketService.DecresaseProductCount(id);

            return Ok(response);
        }

    }
}
