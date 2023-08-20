using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Discount;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;
        private readonly IProductService _productService;

        public DiscountController(IDiscountService discountService, IProductService productService)
        {
            _discountService = discountService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            List<DiscountVM> discounts = new();

            List<Discount> dbDiscounts = await _discountService.GetAllAsync();

            foreach (Discount discount in dbDiscounts)
            {
                discounts.Add(new DiscountVM
                {
                    Id = discount.Id,
                    Name = discount.Name,
                    Percent = discount.Percent,
                    Title = discount.Title,
                    TargetTime = discount.TargetTime,
                    ProductCount = discount.Products.Count,
                });
            }

            return View(discounts);
        }
    }
}
