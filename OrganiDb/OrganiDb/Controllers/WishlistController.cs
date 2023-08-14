using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Wishlist;
using System.Text.Json;

namespace OrganiDb.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly IWishlistService _wishlistService;
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _accesssorService;

        public WishlistController(IBannerService bannerService,
                                  IBannerInfoService bannerInfoService,
                                  IWishlistService wishlistService,
                                  IProductService productService,
                                  IHttpContextAccessor accessorService)
        {
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _wishlistService = wishlistService;
            _productService = productService;
            _accesssorService= accessorService; 
        }

        public async Task<IActionResult> Index()
        {
            List<Banner> banners = await _bannerService.GetAllAsync();
            List<BannerInfo> bannerInfos = await _bannerInfoService.GetAllAsync();
            List<WishlistDetailVM> wishlists = new List<WishlistDetailVM>();

            if (_accesssorService.HttpContext.Request.Cookies["wishlist"] != null)
            {
                List<WishlistViewModel> existedProducts = JsonSerializer.Deserialize<List<WishlistViewModel>>(_accesssorService.HttpContext.Request.Cookies["wishlist"]);

                foreach (WishlistViewModel existedProduct in existedProducts)
                {
                    Product product = await _productService.GetByIdWithImagesAsync(existedProduct.Id);

                    wishlists.Add(new WishlistDetailVM
                    {
                        Id = product.Id,
                        Image = product.ProductImages.Where(m => m.IsMain).FirstOrDefault().Image,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.ActualPrice,
                        DiscountPrice = product.ActualPrice - (product.ActualPrice * product.Discount.Percent) / 100,
                        Percent = product.Discount.Percent,
                    });
                }
            }

            WishlistVM model = new()
            {
                Banners = banners,
                BannerInfos = bannerInfos,
                Wishlists = wishlists,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(int? id)
        {
            Product product = await _productService.GetByIdAsync(id);

            List<WishlistViewModel> wishlist = _wishlistService.GetAllAsync();

            _wishlistService.AddProduct(wishlist, product);

            int grandTotalCount = wishlist.Sum(m => m.Count);

            return Ok(grandTotalCount);
        }
    }
}
