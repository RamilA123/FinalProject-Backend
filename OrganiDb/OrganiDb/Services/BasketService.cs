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
                if(dbProduct.Discount.Percent == 0)
                {
                    grandTotalPrice += dbProduct.ActualPrice * product.Count;
                }
                else
                {
                    grandTotalPrice += (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100) * product.Count;
                }
               
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

        public async Task<BasketCountResponse> IncreaseProductCount(int? id)
        {

            List<BasketVM> existedProducts = JsonSerializer.Deserialize<List<BasketVM>>(_accesssorService.HttpContext.Request.Cookies["basket"]);

            decimal grandTotalPrice = 0;
            decimal totalPrice = 0;
            decimal productPrice = 0;
            int count = 0;

            foreach (BasketVM existedProduct in existedProducts)
            {
                BasketVM existProduct = existedProducts.FirstOrDefault(m => m.Id == id);
                Product dbProduct = await _productService.GetByIdAsync(existedProduct.Id);

               if(existedProduct.Id == id)
               {
                    if (dbProduct.Discount.Percent == 0)
                    {
                        totalPrice = dbProduct.ActualPrice * (existedProduct.Count + 1);
                        productPrice = totalPrice;
                        existedProduct.Count++;
                        count = existedProduct.Count;
                    }

                    else
                    {
                        totalPrice = (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100) * (existedProduct.Count + 1);
                        productPrice = totalPrice;
                        existedProduct.Count++;
                        count = existedProduct.Count;
                    }
                    grandTotalPrice += totalPrice;
               }
               else
               {
                    if (dbProduct.Discount.Percent == 0)
                    {
                        grandTotalPrice += (dbProduct.ActualPrice * existedProduct.Count);
                    }
                    else
                    {
                        grandTotalPrice += (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100) * (existedProduct.Count);
                    }
                   
               }
              
            }

            int grandTotalCount = existedProducts.Sum(m => m.Count);

            _accesssorService.HttpContext.Response.Cookies.Append("basket", JsonSerializer.Serialize(existedProducts));

            return new BasketCountResponse
            {
                TotalPrice = totalPrice,
                GrandTotalPrice = grandTotalPrice,
                GrandTotalCount = grandTotalCount,
                ProductCount = count
            };
        }

        public async Task<BasketCountResponse> DecresaseProductCount(int? id)
        {
            List<BasketVM> existedProducts = JsonSerializer.Deserialize<List<BasketVM>>(_accesssorService.HttpContext.Request.Cookies["basket"]);

            decimal grandTotalPrice = 0;
            decimal totalPrice = 0;
            decimal productPrice = 0;
            int count = 0;

            foreach (BasketVM existedProduct in existedProducts)
            {
                BasketVM existProduct = existedProducts.FirstOrDefault(m => m.Id == id);
                Product dbProduct = await _productService.GetByIdAsync(existedProduct.Id);

                if (existedProduct.Id == id)
                {
                    if (dbProduct.Discount.Percent == 0)
                    {
                        if (existedProduct.Count > 1)
                        {
                            totalPrice = dbProduct.ActualPrice * (existedProduct.Count - 1);
                            productPrice = totalPrice;
                            existedProduct.Count--;
                            count = existedProduct.Count;
                        }
                        else
                        {
                            totalPrice = dbProduct.ActualPrice;
                            productPrice = totalPrice;
                            count = existedProduct.Count;
                        }
                       
                    }

                    else
                    {
                        if (existedProduct.Count > 1)
                        {
                            totalPrice = (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100) * (existedProduct.Count - 1);
                            productPrice = totalPrice;
                            existedProduct.Count--;
                            count = existedProduct.Count;
                        }
                        else
                        {
                            totalPrice = (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100);
                            productPrice = totalPrice;
                            count = existedProduct.Count;
                        }
                      
                    }
                   grandTotalPrice -= totalPrice;  
                   
                }
                else
                {
                    if (dbProduct.Discount.Percent == 0)
                    {
                        grandTotalPrice -= (dbProduct.ActualPrice * existedProduct.Count);
                    }

                    else
                    {
                        grandTotalPrice -= (dbProduct.ActualPrice - (dbProduct.ActualPrice * dbProduct.Discount.Percent) / 100) * (existedProduct.Count);
                    }
                }
            }

            int grandTotalCount = existedProducts.Sum(m => m.Count);

            _accesssorService.HttpContext.Response.Cookies.Append("basket", JsonSerializer.Serialize(existedProducts));

            return new BasketCountResponse
            {
                TotalPrice = totalPrice,
                GrandTotalPrice = -(grandTotalPrice),
                GrandTotalCount = grandTotalCount,
                ProductCount = count
            };
        }

    }
}
