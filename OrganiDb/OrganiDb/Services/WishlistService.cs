using OrganiDb.Models;
using OrganiDb.Responses;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Wishlist;
using System.Text.Json;

namespace OrganiDb.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IHttpContextAccessor _accesssorService;
        private readonly IProductService _productService;

        public WishlistService(IHttpContextAccessor accesssorService, IProductService productService)
        {
            _accesssorService = accesssorService;
            _productService = productService;
        }

        public void AddProduct(List<WishlistViewModel> wishlist, Product product)
        {
            WishlistViewModel existedProduct = wishlist.FirstOrDefault(m => m.Id == product.Id);

            if (existedProduct == null)
            {
                wishlist.Add(new WishlistViewModel { Id = product.Id, Count = 1 });
            }
            else
            {
                existedProduct.Count++;
            }

            _accesssorService.HttpContext.Response.Cookies.Append("wishlist", JsonSerializer.Serialize(wishlist));
        }

        public WishlistDeleteResponse DeleteProduct(int? id)
        {
            List<WishlistViewModel> wishlist = JsonSerializer.Deserialize<List<WishlistViewModel>>(_accesssorService.HttpContext.Request.Cookies["wishlist"]);

            WishlistViewModel existedProduct = wishlist.FirstOrDefault(m => m.Id == id);

            wishlist.Remove(existedProduct);

            _accesssorService.HttpContext.Response.Cookies.Append("wishlist", JsonSerializer.Serialize(wishlist));

            int grandTotalCount = wishlist.Sum(m => m.Count);

            return new WishlistDeleteResponse { GrandTotalCount = grandTotalCount };
        }

        public List<WishlistViewModel> GetAllAsync()
        {
            List<WishlistViewModel> wishlist;

            if (_accesssorService.HttpContext.Request.Cookies["wishlist"] != null)
            {
                wishlist = JsonSerializer.Deserialize<List<WishlistViewModel>>(_accesssorService.HttpContext.Request.Cookies["wishlist"]);
            }

            else
            {
                wishlist = new List<WishlistViewModel>();
            }

            return wishlist;
        }
    }
}
