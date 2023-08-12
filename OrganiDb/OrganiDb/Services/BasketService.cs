using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Responses;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Cart;
using System.Text.Json;

namespace OrganiDb.Services
{
    public class BasketService : IBasketService
    {
        private readonly IHttpContextAccessor _accesssorService;
        private readonly IProductService _productService;

        public BasketService(IHttpContextAccessor accesssorService, IProductService productService)
        {
            _accesssorService = accesssorService;
            _productService = productService;
        }

        public void AddProduct(List<BasketVM> basket, Product product)
        {
            BasketVM existedProduct = basket.FirstOrDefault(m => m.Id == product.Id);

            if (existedProduct == null)
            {
                basket.Add(new BasketVM { Id = product.Id, Count = 1 });
            }
            else
            {
                existedProduct.Count++;
            }
          
            _accesssorService.HttpContext.Response.Cookies.Append("basket", JsonSerializer.Serialize(basket));
        }

        public async Task<BasketDeleteResponse> DeleteProduct(int? id)
        {
            List<BasketVM> basket = JsonSerializer.Deserialize<List<BasketVM>>(_accesssorService.HttpContext.Request.Cookies["basket"]);

            BasketVM existedProduct = basket.FirstOrDefault(m => m.Id == id);

            basket.Remove(existedProduct);

            _accesssorService.HttpContext.Response.Cookies.Append("basket", JsonSerializer.Serialize(basket));

            decimal grandTotalPrice = 0;

            foreach (BasketVM product in basket)
            {
                Product dbProduct = await _productService.GetByIdAsync(product.Id);
                grandTotalPrice += dbProduct.ActualPrice * product.Count;
            }

            int grandTotalCount = basket.Sum(m => m.Count);


            return new BasketDeleteResponse { GrandTotalPrice = grandTotalPrice, GrandTotalCount = grandTotalCount };   
        }

        public List<BasketVM> GetAllAsync()
        {
            List<BasketVM> basket;

            if (_accesssorService.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonSerializer.Deserialize<List<BasketVM>>(_accesssorService.HttpContext.Request.Cookies["basket"]);
            }

            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }

    }
}
